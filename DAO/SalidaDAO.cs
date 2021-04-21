using Montres.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class SalidaDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public SalidaDAO()
        {
            this.conexion = Conexion.getConexion();
        }

        public List<Salida> MostrarSalidas()
        {
            List<Salida> salidas = new List<Salida>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Salida_Producto";


            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                salidas.Add(new Salida(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetInt32(2),
                    list.GetString(3),
                    list.GetString(4),
                    list.GetString(5),
                    list.GetDateTime(6),
                    list.GetString(7)
                    ));
            }
            list.Dispose();
            comando.Dispose();
            return salidas;

        }

    }
}