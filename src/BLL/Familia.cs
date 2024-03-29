﻿using System;
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
            objAlta.descripcion = UTILITIES.Encriptador.Encriptar(objAlta.descripcion);
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Familia objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Habilitar(BE.Familia objHabilitar)
        {
            return GetInstance().Habilitar(objHabilitar);
        }

        public int Update(BE.Familia objUpdate)
        {
            objUpdate.descripcion = UTILITIES.Encriptador.Encriptar(objUpdate.descripcion);
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Familia> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
