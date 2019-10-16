using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FamiliaUsuario : BE.ICRUD<BE.FamiliaUsuario>
    {
        //Patron singleton
        private static DAL.FamiliaUsuario famUsu_dal;

        private static DAL.FamiliaUsuario GetInstance()
        {
            if (famUsu_dal == null)
            {
                famUsu_dal = new DAL.FamiliaUsuario();
            }

            return famUsu_dal;
        }
        public int Add(BE.FamiliaUsuario objAlta)
        {
            string cadenaDVH = objAlta.id_usuario.ToString() + objAlta.id_familia.ToString();
            DigitoVerificador.ObtenerDVH(cadenaDVH);
            return GetInstance().Add(objAlta);
        }

        public bool Delete(BE.FamiliaUsuario objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.FamiliaUsuario objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaUsuario> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
