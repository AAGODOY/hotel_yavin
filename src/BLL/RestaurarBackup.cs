using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RestaurarBackup
    {
        public int RestaurarBackupSeleccionado(BE.Backup backup)
        {
            DAL.RestaurarBackup restaurarBackup_DAL = new DAL.RestaurarBackup();
            return restaurarBackup_DAL.RestaurarBackupSeleccionado(backup);
        }
    }
}
