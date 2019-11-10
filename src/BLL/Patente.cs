using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Patente : BE.ICRUD<BE.Patente>
    {
        //PATRON SINGLETON
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

        public int Delete(BE.Patente objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Habilitar(BE.Patente objHabilitar)
        {
            return GetInstance().Habilitar(objHabilitar);
        }

        public int Update(BE.Patente objUpdate)
        {
            objUpdate.descripcion = UTILITIES.Encriptador.Encriptar(objUpdate.descripcion);
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Patente> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
