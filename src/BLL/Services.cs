using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(!)
using System.Reflection;
using System.Xml;

namespace BLL
{
    public static class Services
    {

        #region Reflection
        public static dynamic GetPropertyValues(string property, object objeto)
        {
            Type t = objeto.GetType();
            PropertyInfo[] propiedades = t.GetProperties();
            foreach (PropertyInfo propiedad in propiedades)
            {
                if (propiedad.MemberType == MemberTypes.Property)
                {
                    if (propiedad.PropertyType.Name == property)
                    {
                        dynamic values = propiedad.GetValue(objeto, null);
                        return values;
                    }
                }
            }
            return null;
        }
        #endregion

        #region SQL connection

        public static string GetConnectionString()
        {
            string connString = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Hotel Yavin\\Connection_string.xml");
            XmlNodeList nodos;
            nodos = doc.GetElementsByTagName("conexionBD");
            foreach (XmlNode nodo in nodos)
            {
                connString = nodo.SelectSingleNode("connectionString").InnerText;
            }

            return connString;
        }

        public static Boolean ValidarConexion(string connString)
        {
            return DAL.Services.ValidarConexion(connString);
        }

        public static Boolean ValidarConexion(string servidor, string nombreBD, bool seguridadIntegrada, string usuario, string contraseña)
        {
            return DAL.Services.ValidarConexion(servidor, nombreBD, seguridadIntegrada, usuario, contraseña);
        }

        public static void setConnectionString(string servidor, string nombreBD, bool seguridadIntegrada, string usuario, string contraseña)
        {
            string connString = "Data Source=" + servidor + ";Initial Catalog=" + nombreBD + ";";
            if (seguridadIntegrada)
            {
                connString += "Integrated Security=True;";
            }
            else
            {
                connString += "User ID=" + usuario + ";Password=" + contraseña + ";";
            }
            connString = UTILITIES.Encriptador.Encriptar(connString);
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Hotel Yavin\\Connection_string.xml");
            XmlNodeList nodos;
            nodos = doc.GetElementsByTagName("conexionBD");
            foreach (XmlNode nodo in nodos)
                nodo.SelectSingleNode("connectionString").InnerText = connString;
            doc.Save(@"C:\\Hotel Yavin\\Connection_string.xml");
        }

        #endregion

        #region Validación uso patente para usuarios involucrados

        //DEBE RECIBIR: un idUsuario (sobre el que se intenta realizar x acción que impacta en la regla de uso de patentes)
        public static int VerificarUsoPatente(int id_usuario, List<BE.Patente> patentes)
        {
            int validacion = 0;
            if (patentes.Count != 0)
            {
                foreach (BE.Patente patente in patentes)
                {
                    validacion = DAL.Services.VerificarUsoPatente(id_usuario, patente.id);
                    //CONDICION: si ningun usuario tiene la patente (a parte del seleccionado), la acción x no debe realizarse
                    if (validacion == 0)
                    {
                        break;
                    }
                }
                
            }
            else
            {
                //No aplica la validación. Agregar una excepcion ya que no debe recibir el metodo una lista vacía.
                validacion = 99;
            }
            return validacion;
        }

        #endregion

        #region Validación uso patente para usuarios no involucrados

        //DEBE RECIBIR: un listado de patentes para validar si algun usuario lo tiene
        public static int VerificarUsoPatente(List<BE.Patente> patentes)
        {
            int validacion = 0;
            if (patentes.Count != 0)
            {
                foreach (BE.Patente patente in patentes)
                {
                    validacion = DAL.Services.VerificarUsoPatente(0, patente.id);
                    //CONDICION: si un usuario tiene la patente y justo voy a realizar una accion sobre ella, la acción x no debe realizarse
                    if (validacion == 1)
                    {
                        break;
                    }
                }

            }
            else
            {
                //No aplica la validación. Agregar una excepcion ya que no debe recibir el metodo una lista vacía.
                validacion = 99;
            }
            return validacion;
        }

        #endregion

    }
}
