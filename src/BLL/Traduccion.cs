using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Traduccion
    {
        //PATRON SINGLETON
        private static DAL.Traduccion traduccion_dal;

        private static DAL.Traduccion GetInstance()
        {
            if (traduccion_dal == null)
            {
                traduccion_dal = new DAL.Traduccion();
            }

            return traduccion_dal;
        }

        public List<BE.Traduccion> GetTraduccion(int id_usuario)
        {
            return GetInstance().GetTraduccion(id_usuario);
        }
    }
}
