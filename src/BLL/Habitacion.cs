using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Habitacion : BE.ICRUD<BE.Habitacion>
    {
        //PATRON SINGLETON
        private static DAL.Habitacion habitacion_dal;

        private static DAL.Habitacion GetInstance()
        {
            if (habitacion_dal == null)
            {
                habitacion_dal = new DAL.Habitacion();
            }

            return habitacion_dal;
        }

        public int Add(BE.Habitacion objAlta)
        {
            throw new NotImplementedException();
        }

        public int Delete(BE.Habitacion objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Habitacion> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Habitacion objUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
