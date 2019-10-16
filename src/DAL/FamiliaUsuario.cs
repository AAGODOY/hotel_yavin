using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FamiliaUsuario : BE.ICRUD<BE.FamiliaUsuario>
    {
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.FamiliaUsuario objAlta)
        {
            string query = "INSERT INTO FamiliaUsuario VALUES(" + objAlta.id_usuario + "," + objAlta.id_familia + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public bool Delete(BE.FamiliaUsuario objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.FamiliaUsuario objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaUsuario> SelectAll()
        {
            throw new NotImplementedException();
        }
    }
}
