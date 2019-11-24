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
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Cliente objAlta)
        {
            string query = "INSERT INTO Cliente VALUES (" + Convert.ToInt32(objAlta.activo) + "," + "" + objAlta.DVH + ",'" + objAlta.nombre + "'," + "'" + objAlta.apellido + "'," + "" + objAlta.documento + "," + "'" + objAlta.telefono + "'," + "'" + objAlta.email + "'" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Cliente objBaja)
        {
            string query = "UPDATE Cliente SET activo = 0, DVH= " + objBaja.DVH + " where id_cliente =" + objBaja.id_cliente + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.Cliente objHabilitar)
        {
            string query = "UPDATE Cliente SET activo = 1, DVH= " + objHabilitar.DVH + " where id_cliente= " + objHabilitar.id_cliente + "";
            return helper.ExecuteNonQuery(query);
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

        public BE.Cliente SelectById(int id)
        {
            string query = "Select * From Cliente where id_cliente =" + id + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                BE.Cliente cliente = new BE.Cliente();
                while (dataReader.Read())
                {
                    cliente = MapDataReader(dataReader);
                }

                return cliente;
            }
        }

        public int Update(BE.Cliente objUpdate)
        {
            string query = "UPDATE Cliente SET DVH = " + objUpdate.DVH + "," + " nombre = '" + objUpdate.nombre + "'," + "apellido='" + objUpdate.apellido + "'," + "documento =" + objUpdate.documento + "," + "telefono ='" + objUpdate.telefono + "'," + "email ='" + objUpdate.email + "' WHERE id_cliente = " + objUpdate.id_cliente + "";
            return helper.ExecuteNonQuery(query);
        }

        public int UpdateDVH(int DVH, int id_cliente)
        {
            string query = "UPDATE Cliente SET DVH =" + DVH + " WHERE id_cliente=" + id_cliente + "";
            return helper.ExecuteNonQuery(query);
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
