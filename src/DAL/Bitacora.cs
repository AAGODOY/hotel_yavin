using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Bitacora
    {
        HELPER.Help help = new HELPER.Help();

        public int RegistrarEnBitacora(BE.Bitacora InfoBitacora)
        {
            string query = "INSERT INTO Bitacora VALUES (" + InfoBitacora.id_usuario + "," + "convert(datetime, '" + InfoBitacora.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'),'" + InfoBitacora.criticidad + "','" + InfoBitacora.descripcion + "'," + InfoBitacora.DVH + ",'" +InfoBitacora.nombre_usuario + "'" + ")";
            return help.ExecuteNonQuery(query);
        }
    }
}
