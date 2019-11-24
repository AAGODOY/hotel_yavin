using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Cobranza : BE.ICRUD<BE.Cobranza>
    {
        HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Cobranza objAlta)
        {
            string query = "INSERT INTO Cobranza VALUES(" + objAlta.id_reserva + ",'" + objAlta.estado + "'," + objAlta.subtotal + "," + objAlta.total + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Cobranza objBaja)
        {
            string query = "UPDATE Cobranza SET estado= 'CANCELADO' WHERE id_reserva= " + objBaja.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.Cobranza objHabilitar)
        {
            string query = "UPDATE Cobranza SET estado= 'PENDIENTE' WHERE id_reserva= " + objHabilitar.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.Cobranza objUpdate)
        {
            string query = "Update Cobranza SET subtotal= " + objUpdate.subtotal + ", total= " + objUpdate.total + " WHERE id_reserva= " + objUpdate.id_reserva + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Cobranza> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<double> GetPrecios(int id_reserva)
        {
            string query = @"select precio from Habitacion h
                            inner join Reserva r on h.id_habitacion = r.id_habitacion
                            where r.id_reserva = " + id_reserva + @"
                            UNION
                            select precio from ServAdicionales s
                            inner join ServAdicionalesReserva sr on s.id_servicio = sr.id_servicio
                            inner join Reserva r on r.id_reserva = sr.id_reserva
                            where r.id_reserva = " + id_reserva + "";

            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<double> preciosList = new List<double>();
                while (dataReader.Read())
                {
                    double precios = dataReader.GetDouble(0);
                    preciosList.Add(precios);
                }

                return preciosList;
            }
        }
    }
}
