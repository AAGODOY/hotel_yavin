using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pago
    {
        public int id_pago { get; set; }
        public int id_cobro { get; set; }
        public DateTime fecha_pago { get; set; }
        public double monto_pagado { get; set; }
    }
}
