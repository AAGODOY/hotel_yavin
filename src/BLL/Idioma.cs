using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Idioma
    {
        //PATRON SINGLETON
        private static DAL.Idioma idioma_dal;

        private static DAL.Idioma GetInstance()
        {
            if (idioma_dal == null)
            {
                idioma_dal = new DAL.Idioma();
            }

            return idioma_dal;
        }

        public BE.Idioma GetIdioma(int id_usuario)
        {
            return GetInstance().GetIdioma(id_usuario);
        }

        public void UpdateIdioma(int id_idioma, BE.Usuario usu)
        {
            usu.nom_usuario = UTILITIES.Encriptador.Encriptar(usu.nom_usuario);
            usu.id_idioma = id_idioma;
            string cadenaDVH = usu.activo.ToString() + usu.nom_usuario.ToString() + usu.nombre.ToString() + usu.apellido.ToString() + usu.documento.ToString() + usu.domicilio.ToString() + usu.telefono.ToString() + usu.email.ToString() + usu.contraseña.ToString() + usu.cant_ingresos_incorrectos.ToString() + usu.es_primer_login.ToString() + usu.id_idioma.ToString();
            usu.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            GetInstance().UpdateIdioma(id_idioma, usu);

            DigitoVerificador.CalcularDVV("Usuario");
        }

        public List<BE.Idioma> SelectAll()
        {
            return GetInstance().SelectAll();
        }
    }
}
