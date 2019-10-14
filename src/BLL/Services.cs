using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(!)
using System.Reflection;

namespace BLL
{
    public static class Services
    {
        //IMPLEMENTACION PATRON: Reflection
        public static dynamic GetPropertyValues(string property, object objeto){
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
            
    }
}
