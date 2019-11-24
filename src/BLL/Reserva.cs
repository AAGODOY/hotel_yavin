using System;
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
            objBaja = GetInstance().SelectById(objBaja.id_reserva);
            objBaja.activo = false;
            objBaja.estado = "CANCELADA";

            string cadenaDVH = objBaja.id_usuario.ToString() + objBaja.id_cliente.ToString() + objBaja.id_habitacion.ToString() + objBaja.activo.ToString() + objBaja.fecha_ingreso.ToString() + objBaja.fecha_salida.ToString();
            objBaja.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int resultado =  GetInstance().Delete(objBaja);
            DigitoVerificador.CalcularDVV("Reserva");

            return resultado;
        }

        public int Habilitar(BE.Reserva objhabilitar)
        {
            objhabilitar = GetInstance().SelectById(objhabilitar.id_reserva);
            objhabilitar.activo = true;
            objhabilitar.estado = "PENDIENTE";

            string cadenaDVH = objhabilitar.id_usuario.ToString() + objhabilitar.id_cliente.ToString() + objhabilitar.id_habitacion.ToString() + objhabilitar.activo.ToString() + objhabilitar.fecha_ingreso.ToString() + objhabilitar.fecha_salida.ToString();
            objhabilitar.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            
            int resultado = GetInstance().Habilitar(objhabilitar);
            DigitoVerificador.CalcularDVV("Reserva");

            return resultado;
        }

        public int SetEnCurso(BE.Reserva objUpdate)
        {
            objUpdate = GetInstance().SelectById(objUpdate.id_reserva);
            objUpdate.estado = "EN CURSO";

            string cadenaDVH = objUpdate.id_usuario.ToString() + objUpdate.id_cliente.ToString() + objUpdate.id_habitacion.ToString() + objUpdate.activo.ToString() + objUpdate.fecha_ingreso.ToString() + objUpdate.fecha_salida.ToString();
            objUpdate.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            
            int resultado = GetInstance().SetEnCurso(objUpdate);
            DigitoVerificador.CalcularDVV("Reserva");

            return resultado;
        }

        public int SetFinalizada(BE.Reserva objUpdate)
        {
            objUpdate = GetInstance().SelectById(objUpdate.id_reserva);
            objUpdate.estado = "FINALIZADA";

            string cadenaDVH = objUpdate.id_usuario.ToString() + objUpdate.id_cliente.ToString() + objUpdate.id_habitacion.ToString() + objUpdate.activo.ToString() + objUpdate.fecha_ingreso.ToString() + objUpdate.fecha_salida.ToString();
            objUpdate.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int resultado = GetInstance().SetFinalizada(objUpdate);
            DigitoVerificador.CalcularDVV("Reserva");

            return resultado;
        }

        public List<BE.Reserva> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Reserva objUpdate)
        {
            string cadenaDVH = objUpdate.id_usuario.ToString() + objUpdate.id_cliente.ToString() + objUpdate.id_habitacion.ToString() + objUpdate.activo.ToString() + objUpdate.fecha_ingreso.ToString() + objUpdate.fecha_salida.ToString();
            objUpdate.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            int resultado = GetInstance().Update(objUpdate);

            DigitoVerificador.CalcularDVV("Reserva");
            return resultado;
        }

        public int UpdateDVH(int DVH, int id_reserva)
        {
            return GetInstance().UpdateDVH(DVH, id_reserva);
        }

    }
}
