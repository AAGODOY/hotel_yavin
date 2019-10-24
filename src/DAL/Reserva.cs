using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class Reserva : BE.ICRUD<BE.Reserva>
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Reserva objAlta)
        {
            throw new NotImplementedException();
        }

        public int Delete(BE.Reserva objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Reserva> SelectAll()
        {
            string query = "Select * From Reserva";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Reserva> reservaList = new List<BE.Reserva>();
                while (dataReader.Read())
                {
                    BE.Reserva reservas = MapDataReader(dataReader);
                    reservaList.Add(reservas);
                }
                return reservaList;
            }
        }

        public int Update(BE.Reserva objUpdate)
        {
            throw new NotImplementedException();
        }

        private BE.Reserva MapDataReader(SqlDataReader dataReader)
        {
            BE.Reserva reserva = new BE.Reserva();
            reserva.id_reserva = dataReader.GetInt32(0);
            reserva.id_usuario = dataReader.GetInt32(1);
            reserva.id_cliente = dataReader.GetInt32(2);
            reserva.activo = dataReader.GetBoolean(3);
            reserva.DVH = dataReader.GetInt32(4);
            reserva.estado = dataReader.GetString(5);
            reserva.fecha_ingreso = dataReader.GetDateTime(6);
            reserva.fecha_salida = dataReader.GetDateTime(7);

            return reserva;
        }
    }
}
