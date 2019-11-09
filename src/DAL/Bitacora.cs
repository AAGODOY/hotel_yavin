using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Bitacora
    {
        HELPER.Help helper = new HELPER.Help();

        public int RegistrarEnBitacora(BE.Bitacora InfoBitacora)
        {
            string query = "INSERT INTO Bitacora VALUES (" + InfoBitacora.id_usuario + ",'" + InfoBitacora.nombre_usuario + "'," + "convert(datetime, '" + InfoBitacora.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "',101),'" + InfoBitacora.criticidad + "','" + InfoBitacora.descripcion + "'," + InfoBitacora.DVH + "" + ")";
            //string query = "INSERT INTO Bitacora VALUES (" + InfoBitacora.id_usuario + ",'" + InfoBitacora.nombre_usuario + "','" + InfoBitacora.fecha + "','" + InfoBitacora.criticidad + "','" + InfoBitacora.descripcion + "'," + InfoBitacora.DVH + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Bitacora> SelectAll()
        {
            string query = "Select * From Bitacora";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Bitacora> bitacoraList = new List<BE.Bitacora>();
                while (dataReader.Read())
                {
                    BE.Bitacora bitacora = MapDataReader(dataReader);
                    bitacoraList.Add(bitacora);
                }

                return bitacoraList;
            }
        }

        public int UpdateDVH(int DVH, int id_usuario)
        {
            string query = "UPDATE Bitacora SET DVH =" + DVH + " WHERE id_log=" + id_usuario + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Bitacora> GetFiltros(DateTime fecha_desde, DateTime fecha_hasta, string usuarios, string criticidades)
        {
            string query = @"declare @fecha_desde datetime = convert(datetime,'" + fecha_desde + @"',101);
	                         declare @fecha_hasta datetime = convert(datetime,'" + fecha_hasta + @"',101);

		                        select *
		                        from Bitacora b
		                        where b.fecha between @fecha_desde and @fecha_hasta" + "";
            if (usuarios != null)
	        {
		        query += " and b.id_usuario in (" + usuarios + ")";
	        }
            if (criticidades != null)
	        {
		        query += " and b.criticidad in (" + criticidades + ")";
	        }

            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Bitacora> bitacoraList = new List<BE.Bitacora>();
                while (dataReader.Read())
                {
                    BE.Bitacora bitacora = MapDataReader(dataReader);
                    bitacoraList.Add(bitacora);
                }

                return bitacoraList;
            }
           
        }

        private BE.Bitacora MapDataReader(SqlDataReader dataReader)
        {
            BE.Bitacora bitacora = new BE.Bitacora();
            bitacora.id_log = dataReader.GetInt32(0);
            bitacora.id_usuario = dataReader.GetInt32(1);
            bitacora.nombre_usuario = dataReader.GetString(2);
            bitacora.fecha = dataReader.GetDateTime(3);
            bitacora.criticidad = dataReader.GetString(4);
            bitacora.descripcion = dataReader.GetString(5);
            bitacora.DVH = dataReader.GetInt32(6);

            return bitacora;
        }
    }
}
