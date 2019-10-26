using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DigitoVerificador
    {
        public static int CalcularDVV(string entidad)
        {
            DAL.DigitoVerificador digVerificador_DAL = new DAL.DigitoVerificador();

            int sumaDVH;
            sumaDVH = digVerificador_DAL.ObtenerSumaDVH(entidad);

            if (sumaDVH > -1)
            {
              return digVerificador_DAL.ActualizarDVV(entidad, sumaDVH);
            }
            else
	        {
                throw new NotImplementedException();
	        }          
        }
    }
}
