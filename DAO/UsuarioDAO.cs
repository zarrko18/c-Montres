using Montres.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class UsuarioDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public UsuarioDAO()
        {
            this.conexion = Conexion.getConexion();
        }

        public int insertar(Usuario usuario)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "insert into Usuario(Cedula,Nombre,Correo,Telefono,Rol,Estado,Contrasena)values(@Cedula,@Nombre,@Correo,@Telefono,@Rol,@Estado,@Contrasena)";
            comando.Parameters.AddWithValue("@Cedula", usuario.Cedula); ;
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Correo", usuario.Correo);
            comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            comando.Parameters.AddWithValue("@Rol", usuario.Rol);
            comando.Parameters.AddWithValue("@Estado", usuario.Estado);
            comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);

            result = comando.ExecuteNonQuery();

            return result;

        }

        public List<Usuario> MostrarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Usuario";


            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                usuarios.Add(new Usuario(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetString(2),
                    list.GetString(3),
                    list.GetInt32(4),
                    list.GetString(5),
                    list.GetString(6)
                    ));
            }
            list.Dispose();
            comando.Dispose();
            return usuarios;

        }

        public int actualizar(Usuario usuario)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Usuario set Nombre='@Nombre' ,Correo='@Correo' ,Telefono='@Telefono' ,Rol='@Rol',Estado='@Estado'  where Cedula='@Cedula'";
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Correo", usuario.Correo);
            comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            comando.Parameters.AddWithValue("@Rol", usuario.Rol);
            comando.Parameters.AddWithValue("@Estado", usuario.Estado);
            comando.Parameters.AddWithValue("@Cedula", usuario.Cedula);

            result = comando.ExecuteNonQuery();

            return result;

        }

        public string Nombre(string cedula)
        {

      
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select Nombre from Usuario where Cedula = '@Cedula'";
            comando.Parameters.AddWithValue("@Cedula", cedula);

            string res = null;

            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                res = list.GetString(0);
            }
            list.Dispose();
            comando.Dispose();
            return res;
        }


        public List<Usuario> listaUsuarios(string ID)
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Usuario where Cedula='@ID'";
            comando.Parameters.AddWithValue("@ID", ID);

            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                usuarios.Add(new Usuario(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetString(2),
                    list.GetString(3),
                    list.GetInt32(4),
                    list.GetString(5),
                    list.GetString(6)
                    ));
            }
            list.Dispose();
            comando.Dispose();
            return usuarios;

        }

        public int insertarSalida(Salida salida)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "insert into Salida_Producto(Cliente,Descripcion,Cantidad,Encargado,Despacho,Fecha,Numero_Parte,Numero_Factura)values(@Cliente,@Descripcion,@Cantidad,@Encargado,@Despacho,@Fecha,@Numero_Parte,@Numero_Factura)";
            comando.Parameters.AddWithValue("@Cliente", salida.Cliente); 
            comando.Parameters.AddWithValue("@Descripcion", salida.Descripcion);
            comando.Parameters.AddWithValue("@Cantidad", salida.Cantidad);
            comando.Parameters.AddWithValue("@Encargado", salida.Encargado);
            comando.Parameters.AddWithValue("@Despacho", salida.Despacho);
            comando.Parameters.AddWithValue("@Fecha", salida.Fecha);
            comando.Parameters.AddWithValue("@Numero_Parte", salida.Numero_Parte);
            comando.Parameters.AddWithValue("@Numero_Factura", salida.Numero_Factura);

            result = comando.ExecuteNonQuery();

            return result;

        }

        public int Desactivar(string codigo)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Usuario set Estado='Desactivo' where Cedula='@codigo'";
            comando.Parameters.AddWithValue("@codigo", codigo);

            result = comando.ExecuteNonQuery();

            return result;

        }

        public int Contrasena(string codigo, string Contrasena)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Usuario set Contrasena='@Contrasena' where Cedula='@codigo'";
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            comando.Parameters.AddWithValue("@codigo", codigo);

            result = comando.ExecuteNonQuery();

            return result;

        }
    }
}