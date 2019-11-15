using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServAdicional : BE.ICRUD<BE.ServAdicional>
    {
        //PATRON SINGLETON
        private static DAL.ServAdicional servicio_DAL;

        private static DAL.ServAdicional GetInstance()
        {
            if (servicio_DAL == null)
            {
                servicio_DAL = new DAL.ServAdicional();
            }

            return servicio_DAL;
        }

        public int Add(BE.ServAdicional objAlta)
        {
            objAlta.activo = true;
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.ServAdicional objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Habilitar(BE.ServAdicional objHabilitar)
        {
            return GetInstance().Habilitar(objHabilitar);
        }

        public int Update(BE.ServAdicional objUpdate)
        {
            return GetInstance().Update(objUpdate);
        }

        public List<BE.ServAdicional> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
