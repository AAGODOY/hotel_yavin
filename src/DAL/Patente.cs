using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Patente
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=KB33\SQL_EAC;Initial Catalog=HotelYavin;Integrated Security=True");

        public List<BE.Patente> SelectAll()
        {
            string query = "Select * From Patente";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Patente> patList = new List<BE.Patente>();
                while (dataReader.Read())
                {
                    BE.Patente patentes = MapDataReader(dataReader);
                    patList.Add(patentes);
                }

                return patList;
            }
        }

        private BE.Patente MapDataReader(SqlDataReader dataReader)
        {
            BE.Patente patente = new BE.Patente();
            patente.id = dataReader.GetInt32(0);
            patente.descripcion = dataReader.GetString(1);
            patente.activo = dataReader.GetBoolean(2);
            
            return patente;
        }
    }
}
