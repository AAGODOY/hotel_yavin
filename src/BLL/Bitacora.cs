using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Bitacora
    {
        static BE.Bitacora Infobitacora = new BE.Bitacora();
        static string CRITICIDAD_ALTA = "ALTA";
        static string CRITICIDAD_MEDIA = "MEDIA";
        static string CRITICIDAD_BAJA = "BAJA";

        //PATRON SINGLETON
        private static DAL.Bitacora bitacora_dal;

        private static DAL.Bitacora GetInstance()
        {
            if (bitacora_dal == null)
            {
                bitacora_dal = new DAL.Bitacora();
            }

            return bitacora_dal;
        }

        //PATRON TEMPLATE

        public virtual int RegistrarEnBitacora(BE.Usuario usuario, DateTime fecha, string descripcion)
        {
            Infobitacora.id_usuario = usuario.id;
            Infobitacora.nombre_usuario = usuario.nombre;
            Infobitacora.fecha = fecha;
            // LA CRITICIDAD SE DEFINE EN LAS CLASES HIJAS 
            Infobitacora.descripcion = descripcion;

            string cadenaDVH = Infobitacora.id_usuario.ToString() + Infobitacora.nombre_usuario.ToString() + Infobitacora.fecha.ToString("yyyy-MM-dd HH:mm:ss") + Infobitacora.criticidad.ToString() + Infobitacora.descripcion.ToString();
            Infobitacora.DVH = UTILITIES.DigitoVerificador.ObtenerDVH(cadenaDVH);

            int resultado = GetInstance().RegistrarEnBitacora(Infobitacora);

            BLL.DigitoVerificador.CalcularDVV("Bitacora");

            return resultado;
        }

        public List<BE.Bitacora> SelectAll()
        {
            return GetInstance().SelectAll();
        }

        public List<BE.Bitacora> GetFiltros(DateTime fecha_desde, DateTime fecha_hasta, string usuarios, string criticidades)
        {
            return GetInstance().GetFiltros(fecha_desde, fecha_hasta, usuarios, criticidades);
        }


        public class ALTA : Bitacora
        {
            public override int RegistrarEnBitacora(BE.Usuario usuario, DateTime fecha, string descripcion)
            {
                Infobitacora.criticidad = CRITICIDAD_ALTA;
                return base.RegistrarEnBitacora(usuario, fecha, descripcion);
            }
        }
        public class MEDIA : Bitacora
        {
            public override int RegistrarEnBitacora(BE.Usuario usuario, DateTime fecha, string descripcion)
            {
                Infobitacora.criticidad = CRITICIDAD_MEDIA;
                return base.RegistrarEnBitacora(usuario, fecha, descripcion);
            }
        }
        public class BAJA : Bitacora
        {
            public override int RegistrarEnBitacora(BE.Usuario usuario, DateTime fecha, string descripcion)
            {
                Infobitacora.criticidad = CRITICIDAD_BAJA;
                return base.RegistrarEnBitacora(usuario, fecha, descripcion);
            }
        }
    }
}
