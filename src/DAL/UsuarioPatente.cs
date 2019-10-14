using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioPatente : BE.ICRUD<BE.UsuarioPatente>
    {
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=KB33\SQL_EAC;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.UsuarioPatente objAlta)
        {
            string query = "INSERT INTO UsuarioPatente VALUES(" + objAlta.id_patente + "," + objAlta.id_usuario + "," + objAlta.DVH + "," + Convert.ToInt32(objAlta.patenteNegada) + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public bool Delete(BE.UsuarioPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.UsuarioPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
