using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Services
    {
        public static HELPER.Help helper = new HELPER.Help();

        public static Boolean ValidarConexion(string str)
        {
            return helper.ValidarConexion(str);
        }
    }
}
