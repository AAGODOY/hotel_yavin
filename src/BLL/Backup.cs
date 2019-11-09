using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Backup
    {
        public int GenerarBackup(string path, int particiones)
        {
            DAL.Backup backup_DAL = new DAL.Backup();
            return backup_DAL.GenerarBackup(path, particiones);
        }
    }
}
