using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ServAdicionalReserva : BE.ICRUD<BE.ServAdicionalReserva>
    {
        HELPER.Help helper = new HELPER.Help();

        public int Add(BE.ServAdicionalReserva objAlta)
        {
            string query = "INSERT INTO ServAdicionalesReserva VALUES (" + objAlta.id_servicio + "," + objAlta.id_reserva + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.ServAdicionalReserva objBaja)
        {
            string query = "DELETE from ServAdicionalesReserva WHERE id_servicio= " + objBaja.id_servicio + " AND id_reserva= " + objBaja.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.ServAdicionalReserva objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.ServAdicionalReserva> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.ServAdicional> GetServicioReserva(int id_reserva)
        {
            string query = @"Select S.id_servicio, S.activo, S.descripcion, S.precio from ServAdicionales S
                            inner join ServAdicionalesReserva SR on SR.id_servicio = S.id_servicio
                            where SR.id_reserva = " + id_reserva + "";

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
