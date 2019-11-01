using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DigitoVerificador
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int ObtenerSumaDVH(string entidad)
        {
            string query = "SELECT SUM(DVH) from " + entidad;
            return Convert.ToInt32(helper.ExecuteScalar(query));
        }

        public int ActualizarDVV(string entidad, int valor)
        {
            string query = "UPDATE DVV SET valor_dv=" + valor + " WHERE entidad='" + entidad + "'";
            return helper.ExecuteNonQuery(query);
        }

        public int GetDVV(string entidad)
        {
            string query = "SELECT valor_dv from DVV where entidad='" + entidad + "'";
            return Convert.ToInt32(helper.ExecuteScalar(query));
        }
    }
}
