using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Huesped : BE.ICRUD<BE.Huesped>
    {
        //PATRON SINGLETON
        private static DAL.Huesped huesped_dal;

        private static DAL.Huesped GetInstance()
        {
            if (huesped_dal == null)
            {
                huesped_dal = new DAL.Huesped();
            }

            return huesped_dal;
        }

        public int Add(BE.Huesped objAlta)
        {
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Huesped objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Update(BE.Huesped objUpdate)
        {
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Huesped> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public List<BE.Huesped> GetHuespedReserva(int id_reserva)
        {
            return GetInstance().GetHuespedReserva(id_reserva);
        }
    }
}
