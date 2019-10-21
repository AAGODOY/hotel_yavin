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
            objAlta.DVH = DigitoVerificador.ObtenerDVH(cadenaDVH);
            objAlta.activo = true;

            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.Cliente objBaja)
        {
            throw new NotImplementedException();
        }

        public List<BE.Cliente> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int Update(BE.Cliente objUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
