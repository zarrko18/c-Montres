using Montres.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class ParteDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public ParteDAO()
        {
            this.conexion = Conexion.getConexion();
        }


        public List<Partes> MostrarDevolucion(string ID)
        {
            List<Partes> partes = new List<Partes>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Partes";

            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                partes.Add(new Partes(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetString(2),
                    list.GetInt32(3),
                    list.GetInt32(4),
                    list.GetDouble(5),
                    list.GetString(6),
                    list.GetInt32(7),
                    list.GetString(8),
                    list.GetDateTime(9)
                    ));
            }
            list.Dispose();
            comando.Dispose();
            return partes;

        }

        public int insertar(Partes parte)
        {

            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "insert into Partes(Numero_Parte,Descripcion,Ubicacion,Cantidad_Inicial,Cantidad_Stock,Cantidad_Minima,Precio,Fecha_Entrada,Numero_Factura,Proveedor)values(@Numero_Parte,@Descripcion,@Ubicacion,@Cantidad_Inicial,@Cantidad_Stock,@Cantidad_Minima,@Precio,@Fecha_Entrada,@Numero_Factura,@Proveedor)";
            comando.Parameters.AddWithValue("@Numero_Parte", parte.Numero_Parte);
            comando.Parameters.AddWithValue("@Descripcion", parte.Descripcion);
            comando.Parameters.AddWithValue("@Ubicacion", parte.Ubicacion);
            comando.Parameters.AddWithValue("@Cantidad_Inicial", parte.Cantidad_Inicial);
            comando.Parameters.AddWithValue("@Cantidad_Stock", parte.Cantidad_Stock);
            comando.Parameters.AddWithValue("@Cantidad_Minima", parte.Cantidad_Minima);
            comando.Parameters.AddWithValue("@Precio", parte.Precio);
            comando.Parameters.AddWithValue("@Fecha_Entrada", parte.Fecha_Entrada);
            comando.Parameters.AddWithValue("@Numero_Factura", parte.Numero_Factura);
            comando.Parameters.AddWithValue("@Proveedor", parte.Proveedor);


            result = comando.ExecuteNonQuery();

            return result;

        }



        

        public List<Partes> Filtrar(string ID)
        {
            List<Partes> partes = new List<Partes>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Partes where Numero_Parte='@ID'";
            comando.Parameters.AddWithValue("@ID", ID);

            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                partes.Add(new Partes(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetString(2),
                    list.GetInt32(3),
                    list.GetInt32(4),
                    list.GetDouble(5),
                    list.GetString(6),
                    list.GetInt32(7),
                    list.GetString(8),
                    list.GetDateTime(9)
                    ));
            }
            list.Dispose();
            comando.Dispose();
            return partes;

        }



        public int Eliminar(Partes parte)
        {
            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Partes set Descripcion='@Descripcion' ,Ubicacion='@Descripcion' ,Cantidad_Inicial='@Cantidad_Inicial' ,Cantidad_Stock='@Cantidad_Stock',Cantidad_Minima='@Cantidad_Minima',Precio='@Precio',Proveedor='@Proveedor',Numero_Factura='@Numero_Factura'  where Numero_Parte='@Numero_Parte'";
            comando.Parameters.AddWithValue("@Descripcion", parte.Descripcion);
            comando.Parameters.AddWithValue("@Ubicacion", parte.Ubicacion);
            comando.Parameters.AddWithValue("@Cantidad_Inicial", parte.Cantidad_Inicial);
            comando.Parameters.AddWithValue("@Cantidad_Stock", parte.Cantidad_Stock);
            comando.Parameters.AddWithValue("@Cantidad_Minima", parte.Cantidad_Minima);
            comando.Parameters.AddWithValue("@Precio", parte.Precio);
            comando.Parameters.AddWithValue("@Proveedor", parte.Proveedor);
            comando.Parameters.AddWithValue("@Numero_Factura", parte.Numero_Factura);
            comando.Parameters.AddWithValue("@Numero_Parte", parte.Numero_Parte);
            result = comando.ExecuteNonQuery();

            return result;

        }



        public int Retiro(int stock, string codigo)
        {
            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Partes set Cantidad_Stock='@Cantidad_Stock' where Numero_Parte='@Numero_Parte'";
            comando.Parameters.AddWithValue("@Cantidad_Stock", stock);
            comando.Parameters.AddWithValue("@Numero_Parte", codigo);
            result = comando.ExecuteNonQuery();

            return result;

        }




        public int UpdCantidadInicial(int stock, string codigo)
        {
            int result = 0;
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "update Partes set Cantidad_Inicial='@Cantidad_Inicial' where Numero_Parte='@Numero_Parte'";
            comando.Parameters.AddWithValue("@Cantidad_Inicial", stock);
            comando.Parameters.AddWithValue("@Numero_Parte", codigo);
            result = comando.ExecuteNonQuery();

            return result;

        }
    }
}