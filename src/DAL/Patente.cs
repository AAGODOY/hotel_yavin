using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class Patente : BE.ICRUD<BE.Patente>
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=WIN-9V7TIU1AUN6\SQLEXPRESS;Initial Catalog=HotelYavin;Integrated Security=True");
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.Patente objAlta)
        {
            throw new NotImplementedException();
        }

        public int Delete(BE.Patente objBaja)
        {
            throw new NotImplementedException();
        }

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

        public int Update(BE.Patente objUpdate)
        {
            throw new NotImplementedException();
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
