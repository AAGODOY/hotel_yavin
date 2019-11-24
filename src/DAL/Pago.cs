using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Pago : BE.ICRUD<BE.Pago>
    {
        HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Pago objAlta)
        {
            string query = "INSERT INTO Pago VALUES(" + objAlta.id_cobro + "," + "convert(datetime, '" + objAlta.fecha_pago.ToString("yyyy-MM-dd") + "',101)," + objAlta.monto_pagado + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Pago objBaja)
        {
            string query = "DELETE From Pago WHERE id_pago= " + objBaja.id_pago + "AND id_cobro= " + objBaja.id_cobro + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.Pago objUpdate)
        {
            string query = "UPDATE Pago SET fecha_pago= convert(datetime, '" + objUpdate.fecha_pago.ToString("yyyy-MM-dd") + "',101), monto_pagado= " + objUpdate.monto_pagado + " WHERE id_pago= " + objUpdate.id_pago + "AND id_cobro = " + objUpdate.id_cobro + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Pago> SelectAll()
        {
            string query = "SELECT * FROM Pago";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Pago> pagoList = new List<BE.Pago>();
                while (dataReader.Read())
                {
                    BE.Pago pago = MapDataReader(dataReader);
                    pagoList.Add(pago);
                }

                return pagoList;
            }
        }

        public List<BE.Pago> GetPagosCobranza(int id_cobro)
        {
            string query = "SELECT * FROM Pago where id_cobro= " + id_cobro + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Pago> pagoList = new List<BE.Pago>();
                while (dataReader.Read())
                {
                    BE.Pago pago = MapDataReader(dataReader);
                    pagoList.Add(pago);
                }

                return pagoList;
            }
        }

        private BE.Pago MapDataReader(SqlDataReader dataReader)
        {
            BE.Pago pago = new BE.Pago();
            pago.id_pago = dataReader.GetInt32(0);
            pago.id_cobro = dataReader.GetInt32(1);
            pago.fecha_pago = dataReader.GetDateTime(2);
            pago.monto_pagado = dataReader.GetDouble(3);

            return pago;
        }
    }
}
