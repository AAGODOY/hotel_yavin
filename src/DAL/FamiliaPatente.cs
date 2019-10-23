using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FamiliaPatente : BE.ICRUD<BE.FamiliaPatente>
    {
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=WIN-9V7TIU1AUN6\SQLEXPRESS;Initial Catalog=HotelYavin;Integrated Security=True");
        public int Add(BE.FamiliaPatente objAlta)
        {
            string query = "INSERT INTO FamiliaPatente VALUES(" + objAlta.id_Patente + "," + objAlta.id_Familia + "," + objAlta.DVH + "" + ")";
            Console.WriteLine(query);
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.FamiliaPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.FamiliaPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaPatente> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.Patente> GetPatentes(int id_familia)
        {
            string query = "SELECT Patente.id_patente, Patente.descripcion, Patente.activo FROM FamiliaPatente INNER JOIN Patente ON FamiliaPatente.id_patente = Patente.id_patente WHERE id_familia =" + id_familia + "";
            {
                using (SqlDataReader dataReader = helper.ExecuteReader(query))
                {
                    List<BE.Patente> patente_list = new List<BE.Patente>();
                    while (dataReader.Read())
                    {
                        BE.Patente usuarioPatentes = MapDataReaderPat(dataReader);
                        patente_list.Add(usuarioPatentes);
                    }

                    return patente_list;
                }  
            }
        }

        private BE.FamiliaPatente MapDataReaderFamPat(SqlDataReader dataReader)
        {
            BE.FamiliaPatente famPatente = new BE.FamiliaPatente();
            famPatente.id_Patente = dataReader.GetInt32(0);
            famPatente.id_Familia = dataReader.GetInt32(1);
            famPatente.DVH = dataReader.GetInt32(2);

            return famPatente;
        }

        private BE.Patente MapDataReaderPat(SqlDataReader dataReader)
        {
            BE.Patente patente = new BE.Patente();
            patente.id = dataReader.GetInt32(0);
            patente.descripcion = dataReader.GetString(1);
            patente.activo = dataReader.GetBoolean(2);

            return patente;
        }
    }
}
