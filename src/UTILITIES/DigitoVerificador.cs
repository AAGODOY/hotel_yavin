using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILITIES
{
    public class DigitoVerificador
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
    }
}
