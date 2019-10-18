using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class FamiliaUsuario : BE.ICRUD<BE.FamiliaUsuario>
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.FamiliaUsuario objAlta)
        {
            string query = "INSERT INTO FamiliaUsuario VALUES(" + objAlta.id_usuario + "," + objAlta.id_familia + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public bool Delete(BE.FamiliaUsuario objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.FamiliaUsuario objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaUsuario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.Familia> GetFamilias(int idUsuario) 
        {
            string query = "SELECT Familia.id_familia, Familia.descripcion, Familia.activo FROM FamiliaUsuario INNER JOIN Familia ON FamiliaUsuario.id_familia = Familia.id_familia WHERE id_usuario = "+idUsuario+"";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Familia> familia_list = new List<BE.Familia>();
                while (dataReader.Read())
                {
                    BE.Familia familiaUsuario = MapDataReaderFam(dataReader);
                    familia_list.Add(familiaUsuario);
                }

                return familia_list;
            }
        }

        private BE.Familia MapDataReaderFam(SqlDataReader dataReader)
        {
            BE.Familia familia = new BE.Familia();
            familia.id = dataReader.GetInt32(0);
            familia.descripcion = dataReader.GetString(1);
            familia.activo = dataReader.GetBoolean(2);

            return familia;
        }
    }
}
