using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montres.Models
{
    public class Salida
    {
        public Salida(string cliente, string descripcion, int cantidad, string encargado, string despacho, string numero_Factura, DateTime fecha, string numero_Parte)
        {
            Cliente = cliente;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Encargado = encargado;
            Despacho = despacho;
            Numero_Factura = numero_Factura;
            Fecha = fecha;
            Numero_Parte = numero_Parte;
        }

        public string Cliente { set; get; }
        public string Descripcion { set; get; }
        public int Cantidad { set; get; }
        public string Encargado { set; get; }
        public string Despacho { set; get; }
        public string Numero_Factura { set; get; }
        public DateTime Fecha { set; get; }
        public string Numero_Parte { set; get; }
      
    }
}