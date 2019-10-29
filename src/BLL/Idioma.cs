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
    }
}
