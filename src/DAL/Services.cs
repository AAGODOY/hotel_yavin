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

        public static Boolean ValidarConexion(string servidor, string nombreBD, bool seguridadIntegrada, string usuario, string contraseña)
        {
            string connstring = "Data Source=" + servidor + ";Initial Catalog=" + nombreBD + ";";
            if (seguridadIntegrada)
            {
                connstring += "Integrated Security=True;";
            }
            else
            {
                connstring += "User ID=" + usuario + "Password=" + contraseña + ";";
            }
            return helper.ValidarConexion(connstring);
        }
    }
}
