using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DigitoVerificador
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

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
    }
}
