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
            objAlta.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int nuevoUsuPat = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("UsuarioPatente");

            return nuevoUsuPat;
            
        }

        public int Delete(BE.UsuarioPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.UsuarioPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public List<BE.UsuarioPatente> SelectByIdUser(int id_usuario)
        {
            return GetInstance().SelectByIdUser(id_usuario);
        }

        public BE.UsuarioPatente GetUsuarioPatente(int idUsuario, int idPatente)
        {
            return GetInstance().GetUsuarioPatente(idUsuario, idPatente);
        }

        public List<BE.Patente> GetPatentesIndividuales(int id_usuario)
        {
            return GetInstance().GetPatentesIndividuales(id_usuario);
        }

        public List<BE.Patente> GetPatentesUsuario(int id_usuario)
        {
            return GetInstance().GetPatentesUsuario(id_usuario);
        }
    }
}
