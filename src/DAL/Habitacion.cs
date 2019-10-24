using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class Habitacion : BE.ICRUD<BE.Habitacion>
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Habitacion objAlta)
        {
            throw new NotImplementedException();
        }

        public int Delete(BE.Habitacion objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Habitacion> SelectAll()
        {
            string query = "Select * From Habitacion";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Habitacion> habitacionList = new List<BE.Habitacion>();
                while (dataReader.Read())
                {
                    BE.Habitacion habitacion = MapDataReader(dataReader);
                    habitacionList.Add(habitacion);
                }
                return habitacionList;
            }
        }

        public int Update(BE.Habitacion objUpdate)
        {
            throw new NotImplementedException();
        }

        private BE.Habitacion MapDataReader(SqlDataReader dataReader)
        {
            BE.Habitacion habitacion = new BE.Habitacion();
            habitacion.id_habitacion = dataReader.GetInt32(0);
            habitacion.id_reserva = dataReader.GetInt32(1);
            habitacion.estado = dataReader.GetString(2);
            habitacion.tipo_habitacion = dataReader.GetString(3);
            habitacion.descripcion = dataReader.GetString(4);
            habitacion.Nro_habitacion = dataReader.GetString(5);
            habitacion.precio = dataReader.GetFloat(6);

            return habitacion;
        }
    }
}
