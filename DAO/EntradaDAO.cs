using Montres.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montres.DAO
{
    public class EntradaDAO
    {
        public SqlConnection conexion;
        public SqlTransaction transaction;
        public string error;

        public EntradaDAO()
        {
            this.conexion = Conexion.getConexion();
        }



        public List<Entrada> MostrarEntradas()
        {
            List<Entrada> Entradas = new List<Entrada>();
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandText = "select * from Entrada_Partes";


            SqlDataReader list = comando.ExecuteReader();
            while (list.Read())
            {
                Entrada client = new Entrada();
                client.Numero_Parte = list.GetString(0);
                client.Responsable = list.GetString(1);
                client.Fecha = list.GetDateTime(2);        
                client.Cantidad_Ingresada = list.GetInt32(3);
                client.Descripcion = list.GetString(4);
                client.Proveedor = list.GetString(5);
                client.Numero_Factura = list.GetString(6);
                client.Precio = list.GetDouble(7);
                Entradas.Add(client);


             
            }
            list.Dispose();
            comando.Dispose();
            return Entradas;

        }

    }
}