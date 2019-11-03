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
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Patente objAlta)
        {
            throw new NotImplementedException();
        }

        public int Delete(BE.Patente objBaja)
        {
            string query = "UPDATE Patente SET activo = 0 where id_patente =" + objBaja.id + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.Patente objHabilitar)
        {
            string query = "UPDATE Patente SET activo = 1 where id_patente =" + objHabilitar.id + "";
            return helper.ExecuteNonQuery(query);
        }

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
            string query = "UPDATE Patente SET descripcion = '" + objUpdate.descripcion + "' where id_patente = " + objUpdate.id + "";
            return helper.ExecuteNonQuery(query);
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
