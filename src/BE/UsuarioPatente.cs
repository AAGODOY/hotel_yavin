using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioPatente
    {
        public int id_patente { get; set; }
        public int id_usuario { get; set; }
        public int DVH { get; set; }
        public bool patenteNegada { get; set; }
    }
}
