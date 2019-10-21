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
            objAlta.DVH = DigitoVerificador.ObtenerDVH(cadenaDVH);
            return GetInstance().Add(objAlta);
        }

        public int Delete(BE.FamiliaPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.FamiliaPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaPatente> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.Patente> GetPatentes(int id_familia)
        {
            return GetInstance().GetPatentes(id_familia);
        }

    }
}
