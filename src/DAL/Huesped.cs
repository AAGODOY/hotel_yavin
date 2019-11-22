using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Huesped : BE.ICRUD<BE.Huesped>
    {
        HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Huesped objAlta)
        {
            string query = "INSERT into Huesped VALUES(" + objAlta.id_reserva + ",'" + objAlta.nombre + "','" + objAlta.apellido + "'," + objAlta.documento + ",'" + objAlta.telefono + "','" + objAlta.email + "')";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Huesped objBaja)
        {
            string query = "DELETE from Huesped WHERE id_huesped= " + objBaja.id_huesped + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.Huesped objUpdate)
        {
            string query = "UPDATE Huesped SET nombre= '" + objUpdate.nombre + "', apellido= '" + objUpdate.apellido + "', documento= " + objUpdate.documento + ", telefono= '" + objUpdate.telefono + "', email= '" + objUpdate.email + "' WHERE id_huesped= " + objUpdate.id_huesped + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Huesped> SelectAll()
        {
            string query = "Select * From Huesped";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Huesped> huespedList = new List<BE.Huesped>();
                while (dataReader.Read())
                {
                    BE.Huesped huesped = MapDataReader(dataReader);
                    huespedList.Add(huesped);
                }
                return huespedList;
            }
        }

        public List<BE.Huesped> GetHuespedReserva(int id_reserva)
        {
            string query = "select * from huesped where id_reserva = " + id_reserva + "";

            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Huesped> huespedList = new List<BE.Huesped>();
                while (dataReader.Read())
                {
                    BE.Huesped huesped = MapDataReader(dataReader);
                    huespedList.Add(huesped);
                }
                return huespedList;
            }
        }

        private BE.Huesped MapDataReader(SqlDataReader dataReader)
        {
            BE.Huesped huesped = new BE.Huesped();
            huesped.id_huesped = dataReader.GetInt32(0);
            huesped.id_reserva = dataReader.GetInt32(1);
            huesped.nombre = dataReader.GetString(2);
            huesped.apellido = dataReader.GetString(3);
            huesped.documento = dataReader.GetInt32(4);
            huesped.telefono = dataReader.GetString(5);
            huesped.email = dataReader.GetString(6);

            return huesped;
        }
    }
}
