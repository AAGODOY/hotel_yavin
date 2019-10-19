using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class ConfigUsuario
    {
        public static Usuario usuarioLogueado = new Usuario();
        public static List<UsuarioPatente> usuPatentes = new List<UsuarioPatente>();
        public static List<Patente> permisos = new List<Patente>();
        public static string idioma { get; set; }

    }
}
