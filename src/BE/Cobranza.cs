using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cobranza
    {
        public int id_cobro { get; set; }
        public int id_reserva { get; set; }
        public string estado { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
    }
}
