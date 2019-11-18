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
            objAlta.activo = true;
            objAlta.estado = "DISPONIBLE";
            return GetInstance().Add(objAlta);    
        }

        public int Delete(BE.Habitacion objBaja)
        {
           return GetInstance().Delete(objBaja);
        }

        public int Habilitar(BE.Habitacion objHabilitar)
        {
            return GetInstance().Habilitar(objHabilitar);
        }

        public List<BE.Habitacion> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Habitacion objUpdate)
        {
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Habitacion> GetFiltros(DateTime fecha_desde, DateTime fecha_hasta)
        {
           return GetInstance().GetFiltros(fecha_desde, fecha_hasta);
        }
    }
}
