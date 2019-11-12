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
                //usu_dal.GetType().GetProperties(
            }

            return usu_dal;
        }

        public BE.Usuario validarUsuario(BE.Usuario usu)
        {
            //BE.Usuario usu = new BE.Usuario();
            
            try
            {
                usu = Usuario.GetInstance().validarUsu(UTILITIES.Encriptador.Encriptar(usu.nom_usuario), UTILITIES.Encriptador.Encriptar(usu.contraseña));
                usu.nom_usuario = UTILITIES.Encriptador.Desencriptar(usu.nom_usuario);
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
                usu.nom_usuario = UTILITIES.Encriptador.Encriptar(usu.nom_usuario);
                GetInstance().IncrementarIngresosIncorrectos(usu);

                usu.cant_ingresos_incorrectos += 1;
                string cadenaDVH = usu.activo.ToString() + usu.nom_usuario.ToString() + usu.nombre.ToString() + usu.apellido.ToString() + usu.documento.ToString() + usu.domicilio.ToString() + usu.telefono.ToString() + usu.email.ToString() + usu.contraseña.ToString() + usu.cant_ingresos_incorrectos.ToString() + usu.es_primer_login.ToString() + usu.id_idioma.ToString();
                usu.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                GetInstance().UpdateDVH(usu.DVH, usu.id);

                DigitoVerificador.CalcularDVV("Usuario");
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
            objAlta.nom_usuario = UTILITIES.Encriptador.Encriptar(objAlta.nom_usuario);
            //encripto contraseña aleatoria
            objAlta.contraseña = UTILITIES.Encriptador.Encriptar(pwAleatoria);

            string cadenaDVH = objAlta.activo.ToString() + objAlta.nom_usuario.ToString() + objAlta.nombre.ToString() + objAlta.apellido.ToString() + objAlta.documento.ToString() + objAlta.domicilio.ToString() + objAlta.telefono.ToString() + objAlta.email.ToString() + objAlta.contraseña.ToString() + objAlta.cant_ingresos_incorrectos.ToString() + objAlta.es_primer_login.ToString() + objAlta.id_idioma.ToString();
            objAlta.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int nuevoUsu = GetInstance().Add(objAlta);
            DigitoVerificador.CalcularDVV("Usuario");

            return nuevoUsu;

            throw new NotImplementedException();
        }

        public int Delete(BE.Usuario objBaja)
        {
            objBaja = GetInstance().SelectById(objBaja.id);
            objBaja.activo = false;

            string cadenaDVH = objBaja.activo.ToString() + objBaja.nom_usuario.ToString() + objBaja.nombre.ToString() + objBaja.apellido.ToString() + objBaja.documento.ToString() + objBaja.domicilio.ToString() + objBaja.telefono.ToString() + objBaja.email.ToString() + objBaja.contraseña.ToString() + objBaja.cant_ingresos_incorrectos.ToString() + objBaja.es_primer_login.ToString() + objBaja.id_idioma.ToString();
            objBaja.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            GetInstance().UpdateDVH(objBaja.DVH, objBaja.id);

            int resultado = GetInstance().Delete(objBaja);
            DigitoVerificador.CalcularDVV("Usuario");
            return resultado;
        }

        public int Habilitar(BE.Usuario objHabilitar)
        {
            objHabilitar = GetInstance().SelectById(objHabilitar.id);
            objHabilitar.activo = true;

            string cadenaDVH = objHabilitar.activo.ToString() + objHabilitar.nom_usuario.ToString() + objHabilitar.nombre.ToString() + objHabilitar.apellido.ToString() + objHabilitar.documento.ToString() + objHabilitar.domicilio.ToString() + objHabilitar.telefono.ToString() + objHabilitar.email.ToString() + objHabilitar.contraseña.ToString() + objHabilitar.cant_ingresos_incorrectos.ToString() + objHabilitar.es_primer_login.ToString() + objHabilitar.id_idioma.ToString();
            objHabilitar.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            GetInstance().UpdateDVH(objHabilitar.DVH, objHabilitar.id);

            int resultado = GetInstance().Habilitar(objHabilitar);
            DigitoVerificador.CalcularDVV("Usuario");

            return resultado;
        }

        public int Update(BE.Usuario objUpdate)
        {
            objUpdate.nom_usuario = UTILITIES.Encriptador.Encriptar(objUpdate.nom_usuario);
            string cadenaDVH = objUpdate.activo.ToString() + objUpdate.nom_usuario.ToString() + objUpdate.nombre.ToString() + objUpdate.apellido.ToString() + objUpdate.documento.ToString() + objUpdate.domicilio.ToString() + objUpdate.telefono.ToString() + objUpdate.email.ToString() + objUpdate.contraseña.ToString() + objUpdate.cant_ingresos_incorrectos.ToString() + objUpdate.es_primer_login.ToString() + objUpdate.id_idioma.ToString();
            objUpdate.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            int resultado = GetInstance().Update(objUpdate);

            DigitoVerificador.CalcularDVV("Usuario");
            return resultado;
        }

        public int UpdateDVH(int DVH, int id_usuario)
        {
            return GetInstance().UpdateDVH(DVH, id_usuario);
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

        public int modificarContraseña(BE.Usuario usu, string pwActual, string nuevaPw)
        {
            try
            {
                usu.contraseña = UTILITIES.Encriptador.Encriptar(pwActual);
                usu.nom_usuario = UTILITIES.Encriptador.Encriptar(usu.nom_usuario);
                usu.es_primer_login = false;
                int resultado = GetInstance().modificarContraseña(usu.id, usu.contraseña, UTILITIES.Encriptador.Encriptar(nuevaPw));
                
                string cadenaDVH = usu.activo.ToString() + usu.nom_usuario.ToString() + usu.nombre.ToString() + usu.apellido.ToString() + usu.documento.ToString() + usu.domicilio.ToString() + usu.telefono.ToString() + usu.email.ToString() + usu.contraseña.ToString() + usu.cant_ingresos_incorrectos.ToString() + usu.es_primer_login.ToString() + usu.id_idioma.ToString();
                usu.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                GetInstance().UpdateDVH(usu.DVH, usu.id);

                DigitoVerificador.CalcularDVV("Usuario");

                return resultado;
                //return GetInstance().modificarContraseña(UTILITIES.Encriptador.Encriptar(pwActual), UTILITIES.Encriptador.Encriptar(nuevaPw));
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public string GetContraseña(int id_usuario)
        {
            return UTILITIES.Encriptador.Desencriptar(GetInstance().GetContraseña(id_usuario));
        }
    }
}
