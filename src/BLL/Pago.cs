using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pago : BE.ICRUD<BE.Pago>
    {
        private static DAL.Pago pago_dal;

        private static DAL.Pago GetInstance()
        {
            if (pago_dal == null)
            {
                pago_dal = new DAL.Pago();
            }

            return pago_dal;
        }

        public int Add(BE.Pago objAlta)
        {
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Pago objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Update(BE.Pago objUpdate)
        {
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Pago> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public List<BE.Pago> GetPagosCobranza(int id_cobro)
        {
            return GetInstance().GetPagosCobranza(id_cobro);
        }
    }
}
