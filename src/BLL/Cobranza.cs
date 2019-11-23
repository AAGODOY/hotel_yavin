using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cobranza : BE.ICRUD<BE.Cobranza>
    {

        private static DAL.Cobranza cobranza_dal;

        private static DAL.Cobranza GetInstance()
        {
            if (cobranza_dal == null)
            {
                cobranza_dal = new DAL.Cobranza();
            }

            return cobranza_dal;
        }

        public int Add(BE.Cobranza objBaja)
        {
            throw new NotImplementedException();
        }

        public int Add(BE.Cobranza objAlta, int cant_dias)
        {
            List<double> precios = GetInstance().GetPrecios(objAlta.id_reserva);

            double precioDia = 0;

            foreach (double item in precios)
            {
                precioDia += item;
            }

            objAlta.subtotal = precioDia * cant_dias;
            objAlta.total = objAlta.subtotal * 0.21d;
            objAlta.estado = "PENDIENTE";

            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Cobranza objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.Cobranza objUpdate)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.Cobranza objUpdate, int dias)
        {
            List<double> precios = GetInstance().GetPrecios(objUpdate.id_reserva);

            double precioDia = 0;

            foreach (double item in precios)
            {
                precioDia += item;
            }

            objUpdate.subtotal = precioDia * dias;
            objUpdate.total = objUpdate.subtotal * 0.21d;

            return GetInstance().Update(objUpdate);
        }

        public List<BE.Cobranza> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
