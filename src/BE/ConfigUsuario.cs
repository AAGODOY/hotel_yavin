using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class ConfigUsuario
    {
        public static Usuario usuarioLogueado{ get; set; }
        public static List<Patente> patentes { get; set; }
        public static List<Familia> familias { get; set; }
        public static List<Patente> permisos { get; set; }
        public static string idioma { get; set; }

    }
}
