using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioPatente : BE.ICRUD<BE.UsuarioPatente>
    {
        //Patron singleton
        private static DAL.UsuarioPatente usuPat_dal;

        private static DAL.UsuarioPatente GetInstance()
        {
            if (usuPat_dal == null)
            {
                usuPat_dal = new DAL.UsuarioPatente();
            }

            return usuPat_dal;
        }


        public int Add(BE.UsuarioPatente objAlta)
        {
            string cadenaDVH = objAlta.id_patente.ToString() + objAlta.id_usuario.ToString() + objAlta.patenteNegada.ToString();
            objAlta.DVH = DigitoVerificador.ObtenerDVH(cadenaDVH);

            return GetInstance().Add(objAlta);
            throw new NotImplementedException();
        }

        public bool Delete(BE.UsuarioPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.UsuarioPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectById(int id_usuario)
        {
            return GetInstance().SelectById(id_usuario);
        }

        public List<BE.Patente> GetPatentes(int id_usuario)
        {
            return GetInstance().GetPatentes(id_usuario);
        }
    }
}
