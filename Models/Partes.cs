using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montres.Models
{
    public class Partes
    {
        public Partes(string numero_Parte, string descripcion, string ubicacion, int cantidad_Inicial, int cantidad_Stock, double precio, string proveedor, int cantidad_Minima, string numero_Factura, DateTime fecha_Entrada)
        {
            Numero_Parte = numero_Parte;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Cantidad_Inicial = cantidad_Inicial;
            Cantidad_Stock = cantidad_Stock;
            Precio = precio;
            Proveedor = proveedor;
            Cantidad_Minima = cantidad_Minima;
            Numero_Factura = numero_Factura;
            Fecha_Entrada = fecha_Entrada;
        }

        public Partes(string numero_Parte, string descripcion, string ubicacion, int cantidad_Minima, int cantidad_Stock)
        {
            Numero_Parte = numero_Parte;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Cantidad_Minima = cantidad_Minima;
            Cantidad_Stock = cantidad_Stock;
        }

        public string Numero_Parte { set; get; }
        public string Descripcion { set; get; }
        public string Ubicacion { set; get; }
        public int Cantidad_Inicial { set; get; }
        public int Cantidad_Stock { set; get; }
        public Double Precio { set; get; }
        public string Proveedor { set; get; }
        public int Cantidad_Minima { set; get; }   
        public string Numero_Factura { set; get; }
        public DateTime Fecha_Entrada { set; get; }

    }
}