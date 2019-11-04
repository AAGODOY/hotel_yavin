using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Familia : BE.ICRUD<BE.Familia>
    {
        private static DAL.Familia familia_dal;

        private static DAL.Familia GetInstance()
        {
            if (familia_dal == null)
            {
                familia_dal = new DAL.Familia();
            }

            return familia_dal;
        }

        public int Add(BE.Familia objAlta)
        {
            objAlta.activo = true;
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Familia objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.Familia objUpdate)
        {
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Familia> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
