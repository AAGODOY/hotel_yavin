using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DigitoVerificador
    {
        public static int ObtenerDVH(string value)
        {
            int valorConvertido = 0;
            List<int> listaValoresConvertidos = new List<int>();
            int digitoObtenido = 0;

            for (int i = 0; i < value.Length; i++)
            {
                valorConvertido = (int)value[i] * (i + 1);
                listaValoresConvertidos.Add(valorConvertido);
            }
            //Console.WriteLine("ASCII: " + listaValoresConvertidos);
            //Console.WriteLine("Length: " + listaValoresConvertidos.Count);
            digitoObtenido = listaValoresConvertidos.Sum();
            return digitoObtenido;
        }

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
