using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ServAdicional : BE.ICRUD<BE.ServAdicional>
    {
        HELPER.Help helper = new HELPER.Help();

        public int Add(BE.ServAdicional objAlta)
        {
            string query = "INSERT INTO ServAdicionales VALUES (" + Convert.ToInt32(objAlta.activo) + ",'" + objAlta.descripcion + "'," + objAlta.precio + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.ServAdicional objBaja)
        {
            string query = "UPDATE ServAdicionales SET activo = 0 where id_servicio =" + objBaja.id_servicio + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.ServAdicional objHabilitar)
        {
            string query = "UPDATE ServAdicionales SET activo = 1 where id_servicio = " + objHabilitar.id_servicio + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.ServAdicional objUpdate)
        {
            string query = "UPDATE ServAdicionales SET descripcion = '" + objUpdate.descripcion + "'," + " precio = " + objUpdate.precio + " WHERE id_servicio = " + objUpdate.id_servicio + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.ServAdicional> SelectAll()
        {
            string query = "Select * From ServAdicionales";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.ServAdicional> serviciosList = new List<BE.ServAdicional>();
                while (dataReader.Read())
                {
                    BE.ServAdicional servicios = MapDataReader(dataReader);
                    serviciosList.Add(servicios);
                }
                return serviciosList;
            }
        }

        private BE.ServAdicional MapDataReader(SqlDataReader dataReader)
        {
            BE.ServAdicional servicio = new BE.ServAdicional();
            servicio.id_servicio = dataReader.GetInt32(0);
            servicio.activo = dataReader.GetBoolean(1);
            servicio.descripcion = dataReader.GetString(2);
            servicio.precio = dataReader.GetDouble(3);

            return servicio;
        }
    }
}
