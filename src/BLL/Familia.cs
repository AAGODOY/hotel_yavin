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
            throw new NotImplementedException();
        }

        public bool Delete(BE.Familia objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.Familia objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.Familia> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
