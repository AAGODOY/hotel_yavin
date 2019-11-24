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
            string query = "INSERT INTO Reserva OUTPUT inserted.id_reserva VALUES (" + objAlta.id_usuario + "," + objAlta.id_cliente + "," + objAlta.id_habitacion + "," + Convert.ToInt32(objAlta.activo) + "," + objAlta.DVH + ",'" + objAlta.estado + "'," + "convert(datetime, '" + objAlta.fecha_ingreso.ToString("yyyy-MM-dd HH:mm:ss") + "',101)," + "convert(datetime, '" + objAlta.fecha_salida.ToString("yyyy-MM-dd HH:mm:ss") + "',101)" + ")";

            int nuevoId = (int)helper.ExecuteScalar(query);
            return nuevoId;
        }

        public int Delete(BE.Reserva objBaja)
        {
            string query = "UPDATE Reserva SET estado= 'CANCELADA', activo= " + Convert.ToInt32(objBaja.activo) + ", DVH = " + objBaja.DVH + "WHERE id_reserva= " + objBaja.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.Reserva objhabilitar)
        {
            string query = "UPDATE Reserva SET estado= 'PENDIENTE', activo= " + Convert.ToInt32(objhabilitar.activo) + ", DVH = " + objhabilitar.DVH + " WHERE id_reserva= " + objhabilitar.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int SetEnCurso(BE.Reserva objUpdate)
        {
            string query = "UPDATE Reserva SET estado= 'EN CURSO', DVH = " + objUpdate.DVH + " WHERE id_reserva= " + objUpdate.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int SetFinalizada(BE.Reserva objUpdate)
        {
            string query = "UPDATE Reserva SET estado= 'FINALIZADA', DVH = " + objUpdate.DVH + " WHERE id_reserva= " + objUpdate.id_reserva + "";
            return helper.ExecuteNonQuery(query);
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

        public BE.Reserva SelectById(int id)
        {
            string query = "Select * From Reserva where id_reserva =" + id + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                BE.Reserva reserva = new BE.Reserva();
                while (dataReader.Read())
                {
                    reserva = MapDataReader(dataReader);
                }

                return reserva;
            }
        }

        public int Update(BE.Reserva objUpdate)
        {
            string query = "UPDATE Reserva SET id_usuario= " + objUpdate.id_usuario + "," + "id_cliente= " + objUpdate.id_cliente + "," + "id_habitacion= " + objUpdate.id_habitacion + "," + "DVH =" + objUpdate.DVH + "," + "fecha_ingreso= convert(datetime, '" + objUpdate.fecha_ingreso.ToString("yyyy-MM-dd HH:mm:ss") + "',101)," + " fecha_salida= convert(datetime, '" + objUpdate.fecha_salida.ToString("yyyy-MM-dd HH:mm:ss") + "',101) WHERE id_reserva= " + objUpdate.id_reserva + "";

            return helper.ExecuteNonQuery(query);
        }

        public int UpdateDVH(int DVH, int id_reserva)
        {
            string query = "UPDATE Reserva SET DVH =" + DVH + " WHERE id_reserva= " + id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        private BE.Reserva MapDataReader(SqlDataReader dataReader)
        {
            BE.Reserva reserva = new BE.Reserva();
            reserva.id_reserva = dataReader.GetInt32(0);
            reserva.id_usuario = dataReader.GetInt32(1);
            reserva.id_cliente = dataReader.GetInt32(2);
            reserva.id_habitacion = dataReader.GetInt32(3);
            reserva.activo = dataReader.GetBoolean(4);
            reserva.DVH = dataReader.GetInt32(5);
            reserva.estado = dataReader.GetString(6);
            reserva.fecha_ingreso = dataReader.GetDateTime(7);
            reserva.fecha_salida = dataReader.GetDateTime(8);

            return reserva;
        }
    }
}
