using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int id { get; set; }
        public bool activo { get; set; }
        public string nom_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int documento { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string area { get; set; }
        public string contraseña { get; set; }
        public int cant_ingresos_incorrectos { get; set; }
        public int DVH { get; set; }
        public bool es_primer_login { get; set; }
        public int id_idioma { get; set; }
    }
}
