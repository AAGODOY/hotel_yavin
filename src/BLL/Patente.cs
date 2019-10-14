using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Patente : BE.ICRUD<BE.Patente>
    {

        private static DAL.Patente patente_dal;

        private static DAL.Patente GetInstance()
        {
            if (patente_dal == null)
            {
                patente_dal = new DAL.Patente();
            }

            return patente_dal;
        }


        public int Add(BE.Patente objAlta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(BE.Patente objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Patente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.Patente> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
