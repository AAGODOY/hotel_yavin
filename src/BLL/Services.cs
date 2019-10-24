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
    }
}
