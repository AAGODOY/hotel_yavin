using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FamiliaPatente : BE.ICRUD<BE.FamiliaPatente>
    {
        //Patron singleton
        private static DAL.FamiliaPatente famPat_dal;

        private static DAL.FamiliaPatente GetInstance()
        {
            if (famPat_dal == null)
            {
                famPat_dal = new DAL.FamiliaPatente();
            }

            return famPat_dal;
        }

        public int Add(BE.FamiliaPatente objAlta)
        {
            string cadenaDVH = objAlta.id_Patente.ToString() + objAlta.id_Familia.ToString();
            objAlta.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int nuevaFamPatente = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("FamiliaPatente");

            return nuevaFamPatente;
        }

        public int Delete(BE.FamiliaPatente objBaja)
        {
            int resultado = GetInstance().Delete(objBaja);

            DigitoVerificador.CalcularDVV("FamiliaPatente");

            return resultado;
        }

        public int UpdateDVH(int DVH, int id_patente, int id_familia)
        {
            return GetInstance().UpdateDVH(DVH, id_patente, id_familia);
        }

        public int Update(BE.FamiliaPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaPatente> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public List<BE.Patente> GetPatentesFamilia(int id_familia)
        {
            return GetInstance().GetPatentesFamilia(id_familia);
        }

    }
}
