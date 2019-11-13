using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Idioma
    {
        public static HELPER.Help helper = new HELPER.Help();

        public BE.Idioma GetIdioma(int id_usuario)
        {
            string query = "SELECT i.id_idioma, i.descripcion from Usuario u INNER JOIN Idioma i on i.id_idioma = u.id_idioma where id_usuario =" + id_usuario + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                BE.Idioma idioma = new BE.Idioma();
                while (dataReader.Read())
                {
                    idioma = MapDataReaderIdioma(dataReader);
                }

                return idioma;
            }
        }

        public List<BE.Idioma> SelectAll()
        {
            string query = "Select * From Idioma";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Idioma> idiomaList = new List<BE.Idioma>();
                while (dataReader.Read())
                {
                    BE.Idioma idioma = MapDataReaderIdioma(dataReader);
                    idiomaList.Add(idioma);
                }

                return idiomaList;
            }
        }

        public void UpdateIdioma(int id_idioma, BE.Usuario usu)
        {
            string query = "UPDATE Usuario SET id_idioma = " + id_idioma + ", DVH= " + usu.DVH + " where id_usuario= '" + usu.id + "'";
            helper.ExecuteNonQuery(query);
        }

        private BE.Idioma MapDataReaderIdioma(SqlDataReader dataReader)
        {
            BE.Idioma idioma = new BE.Idioma();
            idioma.id_idioma = dataReader.GetInt32(0);
            idioma.descripcion = dataReader.GetString(1);

            return idioma;
        }
    }
}
