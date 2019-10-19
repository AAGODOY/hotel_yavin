using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ConfigUsuario
    {

        public static void FijarPermisos(List<BE.UsuarioPatente> usuPatentes, List<BE.Patente> patentes, List<BE.Familia> familias) 
        {
            //LISTA DEFINITVA: patentes individuales + patentes de familias  | no negadas

            //PASO 1: Patente-familia
            BLL.FamiliaPatente famPat_BLL = new BLL.FamiliaPatente();
            foreach (BE.Familia familia in familias) 
            {
                foreach(BE.Patente patente in famPat_BLL.GetPatentes(familia.id))
                {
                    //if (!BE.ConfigUsuario.permisos.Contains(patente))
                    //{
                    //    BE.ConfigUsuario.permisos.Add(patente);
                    //}
                    if (!BE.ConfigUsuario.permisos.Any(p => p.id == patente.id))
                    {
                        BE.ConfigUsuario.permisos.Add(patente);
                    }
                }
            }

            //PASO 2: Patente-individual
            BE.ConfigUsuario.usuPatentes = usuPatentes;
            BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
            foreach (BE.Patente patente in patentes)
            {
                //QUITAR: Si la patente ya se agregó (por la familia) pero esta negada individualmente
                //if (BE.ConfigUsuario.permisos.Contains(patente))
                //{
                if (BE.ConfigUsuario.permisos.Any(p => p.id == patente.id))
                {
                    if (BLL.ConfigUsuario.estaNegada(patente.id))
                    {
                        //BE.ConfigUsuario.permisos.Remove(patente);
                        BE.ConfigUsuario.permisos.RemoveAll(p => p.id == patente.id);
                    }
                }                 
                //}
                //AGREGAR: Si la patente individual no se agregó por la familia y no está negada
                else
                {
                    if (!BLL.ConfigUsuario.estaNegada(patente.id))
                    {
                        BE.ConfigUsuario.permisos.Add(patente);
                    }
                }
            }
        }

        public static bool ValidarAcceso(string nombrePatente)
        {
            BLL.UsuarioPatente usuPat_BLL = new BLL.UsuarioPatente();
            foreach (BE.Patente patente in BE.ConfigUsuario.permisos)
            {
                if (patente.descripcion == nombrePatente)
                {
                   return true;
                }
            }
            return false;
        }

        private static bool estaNegada(int id_patente)
        {
            foreach (BE.UsuarioPatente usuPat in BE.ConfigUsuario.usuPatentes)
            {
                //if (usuPat.id_usuario == BE.ConfigUsuario.usuarioLogueado.id && usuPat.id_patente == id_patente)
                if(usuPat.id_patente == id_patente)
                {
                    if (usuPat.patenteNegada)
                        return true;
                }
            }
            return false;
        }
    }
}
