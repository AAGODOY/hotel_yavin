using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Familia : BE.ICRUD<BE.Familia>
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.Familia objAlta)
        {
            string query = "INSERT INTO Familia OUTPUT inserted.id_familia VALUES (" + "'" + objAlta.descripcion + "'," + Convert.ToInt32(objAlta.activo) + "" + ")";
            int nuevoId = (int)helper.ExecuteScalar(query);
            //int resultado = helper.ExecuteNonQuery(query);
            return nuevoId;
        }

        public int Delete(BE.Familia objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.Familia objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.Familia> SelectAll()
        {
            string query = "SELECT * from Familia";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Familia> familiaList = new List<BE.Familia>();
                while (dataReader.Read())
                {
                    BE.Familia familias = MapDataReader(dataReader);
                    familiaList.Add(familias);
                }

                return familiaList;
            }
        }

        private BE.Familia MapDataReader(SqlDataReader dataReader)
        {
            BE.Familia familia = new BE.Familia();
            familia.id = dataReader.GetInt32(0);
            familia.descripcion = dataReader.GetString(1);
            familia.activo = dataReader.GetBoolean(2);

            return familia;
        }
    }
}
