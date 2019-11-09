using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Backup
    {
        //Patron singleton
        private static DAL.Backup backup_dal;

        private static DAL.Backup GetInstance()
        {
            if (backup_dal == null)
            {
                backup_dal = new DAL.Backup();
            }

            return backup_dal;
        }

        public int GenerarBackup(string path, int particiones)
        {
            return GetInstance().GenerarBackup(path, particiones);
        }

        public List<BE.Backup> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public int AddBackup(BE.Backup backup)
        {
            return GetInstance().AddBackup(backup);
        }


    }
}
