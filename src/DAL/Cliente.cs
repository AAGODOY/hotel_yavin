using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class Cliente : BE.ICRUD<BE.Cliente>
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.Cliente objAlta)
        {
            string query = "INSERT INTO Cliente VALUES (" + Convert.ToInt32(objAlta.activo) + "," + "" + objAlta.DVH + ",'" + objAlta.nombre + "'," + "'" + objAlta.apellido + "'," + "" + objAlta.documento + "," + "'" + objAlta.telefono + "'," + "'" + objAlta.email + "'" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Cliente objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Cliente> SelectAll()
        {
            string query = "Select * From Cliente";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Cliente> clientList = new List<BE.Cliente>();
                while (dataReader.Read())
                {
                    BE.Cliente clientes = MapDataReader(dataReader);
                    clientList.Add(clientes);
                }
                return clientList;
            }
        }

        public int Update(BE.Cliente objUpdate)
        {   
            throw new NotImplementedException();
        }

        private BE.Cliente MapDataReader(SqlDataReader dataReader)
        {
            BE.Cliente cliente = new BE.Cliente();
            cliente.id_cliente = dataReader.GetInt32(0);
            cliente.activo = dataReader.GetBoolean(1);
            cliente.DVH = dataReader.GetInt32(2);
            cliente.nombre = dataReader.GetString(3);
            cliente.apellido = dataReader.GetString(4);
            cliente.documento = dataReader.GetInt32(5);
            cliente.telefono = dataReader.GetString(6);
            cliente.email = dataReader.GetString(7);

            return cliente;
        }
    }
}
