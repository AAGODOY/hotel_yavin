using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RestaurarBackup
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int RestaurarBackupSeleccionado(BE.Backup backup)
        {
            try
            {
                //Modifico la base a Single User
                string query_singleUser = "ALTER DATABASE HotelYavin SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                helper.ExecuteNonQuery(query_singleUser);
            }
            catch (Exception)
            {
               
            }

            try
            {
                //Obtengo las particiones
                string mainPath = backup.ruta + "\\" + backup.descripcion;
                string particionPath = "";

                for (int i = 1; i <= backup.nro_particiones; i++)
                {
                    particionPath += " DISK = '" + mainPath + "." + i + ".bak'";
                    if (i < backup.nro_particiones)
                        particionPath += ",";
                }

                //Realizo la restauracion de la BD
                string query_restore = @"USE MASTER RESTORE DATABASE HotelYavin FROM " + particionPath + " WITH REPLACE";
                //string query = @"RESTORE DATABASE HotelYavin FROM " + particionPath;   
                helper.ExecuteNonQuery(query_restore);
            }
            catch (Exception)
            {
                
                throw;
            }

            try
            {
                //Modifico la base a Multi User
                string query_multiUser = "ALTER DATABASE HotelYavin SET MULTI_USER";
                return helper.ExecuteNonQuery(query_multiUser);
            }
            catch (Exception)
            {
                
                throw;
            }    
        }
    }
}
