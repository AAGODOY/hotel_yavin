using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Backup
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int GenerarBackup(string path, int particiones)
        {
            //1) Armado de particiones (string)
            string particionPath = "";

            for (int i = 1; i <= particiones; i++)
            {
                particionPath += " DISK = '" + path + i + ".bak'";
                if (i < particiones)
                    particionPath += ",";
            }

            //2) Armado de la query final
            string query =
            @"BACKUP DATABASE HotelYavin TO " + particionPath + "";

            return helper.ExecuteNonQuery(query);
        }
    }
}
