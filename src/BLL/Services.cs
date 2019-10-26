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

        //IMPLEMENTACION PATRON: Reflection
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
    }
}
