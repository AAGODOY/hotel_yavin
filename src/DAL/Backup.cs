using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                particionPath += " DISK = '" + path + "." + i + ".bak'";
                if (i < particiones)
                    particionPath += ",";
            }

            //2) Armado de la query final
            string query = @"BACKUP DATABASE HotelYavin TO " + particionPath + "";

            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Backup> SelectAll()
        {
            string query = "SELECT * FROM [Backup]";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Backup> backupList = new List<BE.Backup>();
                while (dataReader.Read())
                {
                    BE.Backup backup = MapDataReaderBackup(dataReader);
                    backupList.Add(backup);
                }

                return backupList;
            }
        }

        public int AddBackup(BE.Backup backup)
        {
            string query = "INSERT INTO [Backup] values ('" + backup.descripcion + "','" + backup.ruta + "'," + backup.nro_particiones + ")";

            return helper.ExecuteNonQuery(query);
        }

        //***MAPEOS***//
        private BE.Backup MapDataReaderBackup(SqlDataReader dataReader)
        {
            BE.Backup backup = new BE.Backup();
            backup.id_Backup = dataReader.GetInt32(0);
            backup.descripcion = dataReader.GetString(1);
            backup.ruta = dataReader.GetString(2);
            backup.nro_particiones = dataReader.GetInt32(3);

            return backup;
        }

    }
}
