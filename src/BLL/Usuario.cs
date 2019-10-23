using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace BLL
{
    public class Usuario : BE.ICRUD<BE.Usuario>
    {        
       //Patron singleton
        private static DAL.Usuario usu_dal;

        private static DAL.Usuario GetInstance()
        {
            if (usu_dal == null)
            {
                usu_dal = new DAL.Usuario();
            }

            return usu_dal;
        }

        public BE.Usuario validarUsuario(BE.Usuario usu)
        {
            //BE.Usuario usu = new BE.Usuario();
            
            try
            {
                usu = Usuario.GetInstance().validarUsu(Encriptador.Encriptar(usu.nom_usuario), Encriptador.Encriptar(usu.contraseña));
                usu.nom_usuario = Encriptador.Desencriptar(usu.nom_usuario);
                Console.WriteLine("" + usu);

                //usu = Usuario.GetInsatance().validarUsu(Encriptador.Encriptar(nom_usu), Encriptador.Encriptar(pw));                
                //usu.nom_usuario = Encriptador.Desencriptar(nom_usu);
                //usu.contraseña = Encriptador.Desencriptar(pw);
                //Console.WriteLine("" + usu);
                return usu;
                
            }
            catch (Exception)
            {
                
                throw;
            }

            //return usu;
        }

        public void IncrementarIngresosIncorrectos(BE.Usuario usu)
        {
            try
            {
               usu.nom_usuario = Encriptador.Encriptar(usu.nom_usuario);
               GetInstance().IncrementarIngresosIncorrectos(usu);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int Add(BE.Usuario objAlta)
        {   
            //Seteo valores por defecto
            objAlta.activo = true;
            objAlta.cant_ingresos_incorrectos = 0;
            objAlta.es_primer_login = true;
            objAlta.id_idioma = 1;
            //creo contraseña aleatoria
            string pwAleatoria = GetRandomPw();
            //encripto nombre usuario aleatoria
            objAlta.nom_usuario = Encriptador.Encriptar(objAlta.nom_usuario);
            //encripto contraseña aleatoria
            objAlta.contraseña =  Encriptador.Encriptar(pwAleatoria);

            string cadenaDVH = objAlta.activo.ToString() + objAlta.nom_usuario + objAlta.nombre + objAlta.apellido + objAlta.documento.ToString() + objAlta.domicilio + objAlta.telefono + objAlta.email + objAlta.area + objAlta.contraseña + objAlta.cant_ingresos_incorrectos.ToString() + objAlta.es_primer_login.ToString() + objAlta.id_idioma.ToString();
            objAlta.DVH = DigitoVerificador.ObtenerDVH(cadenaDVH);

            int nuevoUsu = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("Usuario");

            return nuevoUsu;

            throw new NotImplementedException();
        }

        public int Delete(BE.Usuario objBaja)
        {
            return GetInstance().Delete(objBaja);
        }

        public int Habilitar(BE.Usuario objHabilitar)
        {
            return GetInstance().Habilitar(objHabilitar);
        }

        public int Update(BE.Usuario objUpdate)
        {
            string cadenaDVH = objUpdate.activo.ToString() + objUpdate.nom_usuario + objUpdate.nombre + objUpdate.apellido + objUpdate.documento.ToString() + objUpdate.domicilio + objUpdate.telefono + objUpdate.email + objUpdate.area + objUpdate.contraseña + objUpdate.cant_ingresos_incorrectos.ToString() + objUpdate.es_primer_login.ToString() + objUpdate.id_idioma.ToString();
            objUpdate.DVH = DigitoVerificador.ObtenerDVH(cadenaDVH);
            return GetInstance().Update(objUpdate);
        }

        public List<BE.Usuario> SelectAll()
        {
            try
            {
                return GetInstance().SelectAll();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
            
        }

        private string GetRandomPw(int length = 15)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ012345_-$";

            Random random = new Random();

            //selecciono un caracter random del string y creo un array de chars
            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(8, validChars.Length)];
            }

            return new string(chars);
            
        }

        public Boolean modificarContraseña(string pwActual, string nuevaPw)
        {
            try
            {
                return GetInstance().modificarContraseña(Encriptador.Encriptar(pwActual), Encriptador.Encriptar(nuevaPw));
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public string GetContraseña(int id_usuario)
        {
            return Encriptador.Desencriptar(GetInstance().GetContraseña(id_usuario));
        }

    }
}
