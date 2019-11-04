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
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.FamiliaPatente objAlta)
        {
            string query = "INSERT INTO FamiliaPatente VALUES(" + objAlta.id_Patente + "," + objAlta.id_Familia + "," + objAlta.DVH + "" + ")";
            Console.WriteLine(query);
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.FamiliaPatente objBaja)
        {
            string query = "DELETE FROM FamiliaPatente WHERE id_familia =" + objBaja.id_Familia + " and id_patente=" + objBaja.id_Patente + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.FamiliaPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaPatente> SelectAll()
        {
            string query = "Select * From FamiliaPatente";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.FamiliaPatente> famPatList = new List<BE.FamiliaPatente>();
                while (dataReader.Read())
                {
                    BE.FamiliaPatente familiaPatentes = MapDataReaderFamPat(dataReader);
                    famPatList.Add(familiaPatentes);
                }
                return famPatList;
            }
        }

        public List<BE.Patente> GetPatentesFamilia(int id_familia)
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
