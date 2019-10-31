using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Bitacora
    {
        //PATRON SINGLETON
        private static DAL.Bitacora bitacora_dal;

        private static DAL.Bitacora GetInstance()
        {
            if (bitacora_dal == null)
            {
                bitacora_dal = new DAL.Bitacora();
            }

            return bitacora_dal;
        }
    }
}
