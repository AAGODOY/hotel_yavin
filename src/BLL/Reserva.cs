﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Reserva : BE.ICRUD<BE.Reserva>
    {
        //PATRON SINGLETON
        private static DAL.Reserva reserva_dal;

        private static DAL.Reserva GetInstance()
        {
            if (reserva_dal == null)
            {
                reserva_dal = new DAL.Reserva();
            }

            return reserva_dal;
        }

        public int Add(BE.Reserva objAlta)
        {
            //Seteo valores por defecto
            objAlta.activo = true;
            objAlta.estado = "PENDIENTE";

            string cadenaDVH = objAlta.id_usuario.ToString() +  objAlta.id_cliente.ToString() + objAlta.id_habitacion.ToString() + objAlta.activo.ToString() + objAlta.fecha_ingreso.ToString() + objAlta.fecha_salida.ToString();
            objAlta.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int nuevaReseva = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("Reserva");

            return nuevaReseva;
        }

        public int Delete(BE.Reserva objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Reserva> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Reserva objUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
