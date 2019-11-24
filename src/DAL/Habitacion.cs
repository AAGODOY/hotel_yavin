using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class Habitacion : BE.ICRUD<BE.Habitacion>
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.Habitacion objAlta)
        {
            string query = "INSERT INTO Habitacion VALUES (" + Convert.ToInt32(objAlta.activo) + ",'" + objAlta.tipo_habitacion + "','" + objAlta.descripcion + "','" + objAlta.Nro_habitacion + "'," + objAlta.precio + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.Habitacion objBaja)
        {
            string query = "UPDATE Habitacion SET activo = 0 where id_habitacion =" + objBaja.id_habitacion + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Habilitar(BE.Habitacion objHabilitar)
        {
            string query = "UPDATE Habitacion SET activo = 1 where id_habitacion= " + objHabilitar.id_habitacion + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Habitacion> SelectAll()
        {
            string query = "Select * From Habitacion";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Habitacion> habitacionList = new List<BE.Habitacion>();
                while (dataReader.Read())
                {
                    BE.Habitacion habitacion = MapDataReader(dataReader);
                    habitacionList.Add(habitacion);
                }
                return habitacionList;
            }
        }

        public int Update(BE.Habitacion objUpdate)
        {
            string query = "UPDATE Habitacion SET tipo_habitacion = '" + objUpdate.tipo_habitacion + "'," + " descripcion = '" + objUpdate.descripcion + "'," + "nro_habitacion='" + objUpdate.Nro_habitacion + "'," + "precio =" + objUpdate.precio + " where id_habitacion= " + objUpdate.id_habitacion + "";

            return helper.ExecuteNonQuery(query);
        }

        public List<BE.Habitacion> GetFiltros(DateTime fecha_desde, DateTime fecha_hasta)
        {
            string query = @"DECLARE @fechaIngreso DATE = '" + fecha_desde + @"'
                            DECLARE @fechaSalida DATE = '" + fecha_hasta + @"'

                            SELECT * FROM Habitacion
                            EXCEPT
                            SELECT h.id_habitacion, h.activo, h.tipo_habitacion, h.descripcion, h.nro_habitacion, h.precio
                            FROM Habitacion h
                            INNER JOIN Reserva r ON h.id_habitacion = r.id_habitacion
                            WHERE 
                            r.estado IN ('PENDIENTE','EN CURSO') AND
                            ( 
	                            (r.fecha_ingreso BETWEEN @fechaIngreso AND @fechaSalida) 
	                            AND 
	                            (r.fecha_salida BETWEEN @fechaIngreso AND @fechaSalida) 
                            )";

            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Habitacion> habitacionList = new List<BE.Habitacion>();
                while (dataReader.Read())
                {
                    BE.Habitacion habitacion = MapDataReader(dataReader);
                    habitacionList.Add(habitacion);
                }

                return habitacionList;
            }
        }

        private BE.Habitacion MapDataReader(SqlDataReader dataReader)
        {
            BE.Habitacion habitacion = new BE.Habitacion();
            habitacion.id_habitacion = dataReader.GetInt32(0);
            habitacion.activo = dataReader.GetBoolean(1);
            habitacion.tipo_habitacion = dataReader.GetString(2);
            habitacion.descripcion = dataReader.GetString(3);
            habitacion.Nro_habitacion = dataReader.GetString(4);
            habitacion.precio = dataReader.GetDouble(5);

            return habitacion;
        }
    }
}
