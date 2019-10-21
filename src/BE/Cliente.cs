using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public bool activo { get; set; }
        public int DVH { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int documento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}
