using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public int Update(BE.ServAdicionalReserva objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.ServAdicionalReserva> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
