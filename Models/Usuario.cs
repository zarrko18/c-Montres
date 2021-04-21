using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Montres.Models
{
    public class Usuario
    {
        public Usuario(string cedula, string nombre, string correo, string telefono, int rol, string estado, string contrasena)
        {
            Cedula = cedula;
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
            Rol = rol;
            Estado = estado;
            Contrasena = contrasena;
        }

        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Correo { set; get; }
        public string Telefono { set; get; }
        public int Rol { set; get; }
        public string Estado { set; get; }
        public string Contrasena { set; get; }
    }
}