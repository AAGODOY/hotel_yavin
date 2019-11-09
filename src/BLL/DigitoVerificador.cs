using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DigitoVerificador
    {
        static List<string> ErrorIntegridad = new List<string>();

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

        public static int GetDVV(string entidad)
        { 
            DAL.DigitoVerificador DVV_DAL = new DAL.DigitoVerificador();
            return DVV_DAL.GetDVV(entidad);
        }

        

        //VERIFICAR SI SE PUEDE AGREGAR EL PATRON TEMPLATE a la funcionalidad

        public static List<string> VerificarIntegridad()
        {
            List<string> listaErrores = new List<string>();
            foreach (string item in VerificarIntegridadUsuario())
            {
                listaErrores.Add(item);
            }

            foreach (string item in VerificarIntegridadBitacora())
            {
                listaErrores.Add(item);
            }

            return listaErrores;
                //VerificarIntegridadBitacora();
                //VerificarIntegridadCliente();
                //VerificarIntegridadReserva();
                //VerificarIntegridadUsuarioPatente();
                //VerificarIntegridadFamiliaPatente();
        }

        private static List<string> VerificarIntegridadUsuario()
        {
            List<BE.Usuario> listUsu_BE = new List<BE.Usuario>();
            BLL.Usuario usu_BLL = new Usuario();
            listUsu_BE = usu_BLL.SelectAll();

            foreach (BE.Usuario item in listUsu_BE)
            {
                string cadenaDVH = item.activo.ToString() + item.nom_usuario + item.nombre + item.apellido + item.documento.ToString() + item.domicilio + item.telefono + item.email + item.contraseña + item.cant_ingresos_incorrectos.ToString() + item.es_primer_login.ToString() + item.id_idioma.ToString();
                int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                if (item.DVH == DVHCalculado)
                {
                    Console.WriteLine("DVH correcto");
                }
                else
                {
                    string str = "USUARIO - Inconsistencia en la entidad Usuario en el registro numero (ID): " + item.id;
                    ErrorIntegridad.Add(str);
                }
            }

            DAL.DigitoVerificador digitoVerificador_DAL = new DAL.DigitoVerificador();
            int DVVCalculado = digitoVerificador_DAL.ObtenerSumaDVH("Usuario");

            if (DVVCalculado == GetDVV("Usuario"))
            {
                Console.WriteLine("DVV correcto");
            }
            else
            {
                string str = "Inconsistencia en la entidad Usuario al calcular el DVV";
                ErrorIntegridad.Add(str);
            }

            return ErrorIntegridad;
        }

        private static List<string> VerificarIntegridadBitacora()
        {
            List<BE.Bitacora> listBitacora_BE = new List<BE.Bitacora>();
            BLL.Bitacora.BAJA bitacora_BLL = new Bitacora.BAJA();
            listBitacora_BE = bitacora_BLL.SelectAll();

            foreach (BE.Bitacora item in listBitacora_BE)
            {
                string cadenaDVH = item.id_usuario.ToString() + item.nombre_usuario.ToString() + item.fecha.ToString("yyyy-MM-dd HH:mm:ss") + item.criticidad.ToString() + item.descripcion.ToString();
                int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                if (item.DVH == DVHCalculado)
                {
                    Console.WriteLine("DVH correcto");
                }
                else
                {
                    string str = "BITACORA - Inconsistencia en la entidad Bitácora en el registro numero (ID): " + item.id_log;
                    ErrorIntegridad.Add(str);
                }
            }

            DAL.DigitoVerificador digitoVerificador_DAL = new DAL.DigitoVerificador();
            int DVVCalculado = digitoVerificador_DAL.ObtenerSumaDVH("Bitacora");

            if (DVVCalculado == GetDVV("Bitacora"))
            {
                Console.WriteLine("DVV correcto");
            }
            else
            {
                string str = "Inconsistencia en la entidad Bitacora al calcular el DVV";
                ErrorIntegridad.Add(str);
            }

            return ErrorIntegridad;
        }

        private static bool VerificarIntegridadCliente()
        {
            List<BE.Cliente> listCliente_BE = new List<BE.Cliente>();
            BLL.Cliente cliente_BLL = new Cliente();

            listCliente_BE = cliente_BLL.SelectAll();

            foreach (BE.Cliente item in listCliente_BE)
            {
                string cadenaDVH = item.activo.ToString() + item.nombre.ToString() + item.apellido.ToString() + item.documento.ToString() + item.telefono.ToString() + item.email.ToString();
                int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                if (item.DVH == DVHCalculado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private static bool VerificarIntegridadReserva()
        {
            //List<BE.Reserva> listReserva_BE = new List<BE.Reserva>();
            //BLL.Reserva reserva_BLL = new Reserva();

            //listReserva_BE = reserva_BLL.SelectAll();

            //foreach (BE.Reserva item in listReserva_BE)
            //{
            //    string cadenaDVH = item.activo.ToString() + item.estado.ToString() + item.fecha_ingreso.ToString() + item.fecha_salida.ToString();
            //    int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
            //    if (item.DVH == DVHCalculado)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            return false;
        }

        private static bool VerificarIntegridadFamiliaPatente()
        {
            List<BE.FamiliaPatente> listFamPat_BE = new List<BE.FamiliaPatente>();
            BLL.FamiliaPatente famPat_BLL = new FamiliaPatente();

            listFamPat_BE = famPat_BLL.SelectAll();

            foreach (BE.FamiliaPatente item in listFamPat_BE)
            {
                string cadenaDVH = item.id_Patente.ToString() + item.id_Familia.ToString();
                int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                if (item.DVH == DVHCalculado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        private static bool VerificarIntegridadUsuarioPatente()
        {
            List<BE.UsuarioPatente> listUsuPat_BE = new List<BE.UsuarioPatente>();
            BLL.UsuarioPatente usuPat_BLL = new UsuarioPatente();

            listUsuPat_BE = usuPat_BLL.SelectAll();

            foreach (BE.UsuarioPatente item in listUsuPat_BE)
            {
                string cadenaDVH = item.id_patente.ToString() + item.id_usuario.ToString() + item.patenteNegada.ToString();
                int DVHCalculado = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);
                if (item.DVH == DVHCalculado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

    }
}
