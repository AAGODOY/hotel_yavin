using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Cliente : BE.ICRUD<BE.Cliente>
    {
        //PATRON SINGLETON
        private static DAL.Cliente cliente_dal;

        private static DAL.Cliente GetInstance()
        {
            if (cliente_dal == null)
            {
                cliente_dal = new DAL.Cliente();
            }

            return cliente_dal;
        }

        public int Add(BE.Cliente objAlta)
        {
            string cadenaDVH = objAlta.activo.ToString() + objAlta.nombre.ToString() + objAlta.apellido.ToString() + objAlta.documento.ToString() + objAlta.telefono.ToString() + objAlta.email.ToString();
            objAlta.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            objAlta.activo = true;

            int nuevoCliente = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("Cliente");

            return nuevoCliente;
        }

        public int Delete(BE.Cliente objBaja)
        {
            objBaja = GetInstance().SelectById(objBaja.id_cliente);
            objBaja.activo = false;

            string cadenaDVH = objBaja.activo.ToString() + objBaja.nombre.ToString() + objBaja.apellido.ToString() + objBaja.documento.ToString() + objBaja.telefono.ToString() + objBaja.email.ToString();
            objBaja.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            GetInstance().UpdateDVH(objBaja.DVH, objBaja.id_cliente);

            int resultado = GetInstance().Delete(objBaja);
            DigitoVerificador.CalcularDVV("Cliente");
            return resultado;
        }


        public int Habilitar(BE.Cliente objHabilitar)
        {
            objHabilitar = GetInstance().SelectById(objHabilitar.id_cliente);
            objHabilitar.activo = true;

            string cadenaDVH = objHabilitar.activo.ToString() + objHabilitar.nombre.ToString() + objHabilitar.apellido.ToString() + objHabilitar.documento.ToString() + objHabilitar.telefono.ToString() + objHabilitar.email.ToString();
            objHabilitar.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            GetInstance().UpdateDVH(objHabilitar.DVH, objHabilitar.id_cliente);

            int resultado = GetInstance().Habilitar(objHabilitar);
            DigitoVerificador.CalcularDVV("Cliente");

            return resultado;
        }

        public List<BE.Cliente> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Cliente objUpdate)
        {
            string cadenaDVH = objUpdate.activo.ToString() + objUpdate.nombre.ToString() + objUpdate.apellido.ToString() + objUpdate.documento.ToString() + objUpdate.telefono.ToString() + objUpdate.email.ToString();
            objUpdate.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            int resultado = GetInstance().Update(objUpdate);

            DigitoVerificador.CalcularDVV("Cliente");
            return resultado;
        }
    }
}

