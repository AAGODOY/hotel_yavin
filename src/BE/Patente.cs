using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patente
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public Patente()
        {
        }

        public Patente(Patente unaPatente) {
            this.id = unaPatente.id;
            this.descripcion = unaPatente.descripcion;
            this.activo = unaPatente.activo;

        }
    }
}
