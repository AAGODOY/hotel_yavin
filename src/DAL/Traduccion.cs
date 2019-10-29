using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Traduccion
    {
        public static HELPER.Help helper = new HELPER.Help();

        public List<BE.Traduccion> GetTraduccion(int id_usuario)
        {
            string query = "select t.id_traduccion, t.id_idioma, t.traduccion from Idioma i INNER JOIN Traduccion t on t.id_idioma = i.id_idioma INNER JOIN Usuario u on u.id_idioma = i.id_idioma where id_usuario =" + id_usuario + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Traduccion> traducciones = new List<BE.Traduccion>();
                while (dataReader.Read())
                {
                    BE.Traduccion traduccion = MapDataReader(dataReader);
                    traducciones.Add(traduccion);
                }

                return traducciones;
            }
        }

        private BE.Traduccion MapDataReader(SqlDataReader dataReader)
        {
            BE.Traduccion traduccion = new BE.Traduccion();
            traduccion.id_traduccion = dataReader.GetInt32(0);
            traduccion.id_idioma = dataReader.GetInt32(1);
            traduccion.traduccion = dataReader.GetString(2);

            return traduccion;
        }
    }
}
