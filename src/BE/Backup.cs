using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Backup
    {
        public int id_Backup { get; set; }
        public string descripcion { get; set; } // Nombre del archivo + Fecha
        public string ruta { get; set; } // A nivel carpeta
        public int nro_particiones { get; set; } // Total de particiones asociadas a un backup
    }
}
