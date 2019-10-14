using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL
{
    public static class Encriptador
    {
        //1-Definición de llave (salt?)
        static string key = "abc";
        static byte[] keyArray;

        public static string Encriptar(string texto)
        {
            try
            {
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
                //2-Se utilizan las clases de encriptación MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                //3-Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor(); // (!)
                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
                tdes.Clear();
                //4-Definición final del valor a retornar en formato string
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
            }
            catch (Exception)
            {

            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado)
        {
            try
            {
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);
                //2-Se utilizan las clases de encriptación MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                //3-Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
                tdes.Clear();
                //4-Definición final del valor a retornar en formato string
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }
    }
}
