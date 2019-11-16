using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServAdicionalReserva : BE.ICRUD<BE.ServAdicionalReserva>
    {
        //Patron singleton
        private static DAL.ServAdicionalReserva servReserva_dal;

        private static DAL.ServAdicionalReserva GetInstance()
        {
            if (servReserva_dal == null)
            {
                servReserva_dal = new DAL.ServAdicionalReserva();
                //usu_dal.GetType().GetProperties(
            }

            return servReserva_dal;
        }
        
        public int Add(BE.ServAdicionalReserva objAlta)
        {
            return GetInstance().Add(objAlta);
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
