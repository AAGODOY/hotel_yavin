using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//BORRAR!
using System.Text.RegularExpressions;

namespace DAL
{
    public class Usuario : BE.ICRUD<BE.Usuario>
    {
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=KB33\SQL_EAC;Initial Catalog=HotelYavin;Integrated Security=True");
        public BE.Usuario validarUsu(string nom_usu, string pw)
        {
            string query = "SELECT * from Usuario where nombre_usuario='" + nom_usu + "'";
            BE.Usuario usu = new BE.Usuario();

            SqlDataReader Reader;
            try
            {
                Reader = helper.ExecuteReader(query);
                if (Reader.HasRows)
                {
                    Reader.Read();
                    usu.id = Convert.ToInt32(Reader["id_usuario"]);
                    usu.activo = Convert.ToBoolean(Reader["activo"]);
                    usu.nom_usuario = Convert.ToString(Reader["nombre_usuario"]);
                    usu.nombre = Convert.ToString(Reader["nombre"]);
                    usu.apellido = Convert.ToString(Reader["apellido"]);
                    usu.documento = Convert.ToInt32(Reader["documento"]);
                    usu.domicilio = Convert.ToString(Reader["domicilio"]);
                    usu.telefono = Convert.ToString(Reader["telefono"]);
                    usu.email = Convert.ToString(Reader["email"]);
                    usu.area = Convert.ToString(Reader["area"]);
                    usu.contraseña = Convert.ToString(Reader["contraseña"]);
                    usu.cant_ingresos_incorrectos = Convert.ToInt32(Reader["cant_ingresos_incorrectos"]);
                    usu.DVH = Convert.ToInt32(Reader["DVH"]);
                    usu.es_primer_login = Convert.ToBoolean(Reader["es_primer_login"]);
                    usu.id_idioma = Convert.ToInt32(Reader["id_idioma"]);
                    Reader.Close();
                }

                return usu;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void IncrementarIngresosIncorrectos(BE.Usuario usu)
        {
            string query = "UPDATE Usuario SET cant_ingresos_incorrectos = cant_ingresos_incorrectos+1 where nombre_usuario ='" + usu.nom_usuario + "'";
            helper.ExecuteNonQuery(query);
        }


        public int Add(BE.Usuario objAlta)
        {
            //string query = "INSERT INTO Usuario VALUES (" + "'1'," + "'" + objAlta.nom_usuario + "'," + "'" + objAlta.nombre + "'," + "'" + objAlta.apellido + "'," + "" + objAlta.documento + "," + "'" + objAlta.domicilio + "'," + "'" + objAlta.telefono + "'," + "'" + objAlta.email + "'," + "'" + objAlta.area + "'," + "'contraseña'," +"'" + objAlta.contraseña + "'," + "'0'," + "'200'," + "'0'," + "'54733'" + ")";
            string query = "INSERT INTO Usuario OUTPUT inserted.id_usuario VALUES (" + Convert.ToInt32(objAlta.activo) + "," + "'" + objAlta.nom_usuario + "'," + "'" + objAlta.nombre + "'," + "'" + objAlta.apellido + "'," + "" + objAlta.documento + "," + "'" + objAlta.domicilio + "'," + "'" + objAlta.telefono + "'," + "'" + objAlta.email + "'," + "'" + objAlta.area + "'," + "'" + objAlta.contraseña + "'," + objAlta.cant_ingresos_incorrectos + "," + objAlta.DVH + "," + Convert.ToInt32(objAlta.es_primer_login) + "," + objAlta.id_idioma + "" + ")";
            //TEST
            int nuevoId = (int)helper.ExecuteScalar(query);
            //int resultado = helper.ExecuteNonQuery(query);
            return nuevoId;
        }

        public bool Delete(BE.Usuario objBaja)
        {
            throw new NotImplementedException();
        }

        public bool Update(BE.Usuario objUpdate)
        {
            string query = "UPDATE Usuario SET nombre_usuario = '" + objUpdate.nom_usuario + "'," + "nombre ='" + objUpdate.nombre + "'," + "apellido='" + objUpdate.apellido + "'," + "documento =" + objUpdate.documento + "," + "domicilio='" + objUpdate.domicilio + "'," + "telefono ='" + objUpdate.telefono + "'," + "email ='" + objUpdate.email + "'," + "area='" + objUpdate.area + "'" + "";
            //return helper.ExecuteNonQuery(query);
            throw new NotImplementedException();
        }

        public List<BE.Usuario> SelectAll()
        {
            string query = "Select * From Usuario";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Usuario> usuList = new List<BE.Usuario>();
                while (dataReader.Read())
                {
                    BE.Usuario usuarios = MapDataReader(dataReader);
                    usuList.Add(usuarios);
                }

                return usuList;
            }
        }

        public Boolean modificarContraseña(string pwActual, string nuevaPw)
        {
            string validacionPw = "SELECT * from Usuario where contraseña ='" + pwActual + "'";
            string query = "UPDATE Usuario SET contraseña = '" + nuevaPw + "', es_primer_login = 0 where contraseña ='" + pwActual + "'";
            helper.ExecuteReader(validacionPw);
            SqlDataReader dataReader;
            dataReader = helper.ExecuteReader(validacionPw);
            
            if (dataReader.HasRows)
            {
                helper.ExecuteNonQuery(query);
                return true;
            }
            else
            {
                return false;
            }

        }

        private BE.Usuario MapDataReader(SqlDataReader dataReader)
        {
            BE.Usuario usu = new BE.Usuario();
            usu.id = dataReader.GetInt32(0);
            usu.activo = dataReader.GetBoolean(1);
            usu.nom_usuario = dataReader.GetString(2);
            usu.nombre = dataReader.GetString(3);
            usu.apellido = dataReader.GetString(4);
            usu.documento = dataReader.GetInt32(5);
            usu.domicilio = dataReader.GetString(6);
            usu.telefono = dataReader.GetString(7);
            usu.email = dataReader.GetString(8);
            usu.area = dataReader.GetString(9);
            usu.contraseña = dataReader.GetString(10);
            usu.cant_ingresos_incorrectos = dataReader.GetInt32(11);
            usu.DVH = dataReader.GetInt32(12);
            usu.es_primer_login = dataReader.GetBoolean(13);
            usu.id_idioma = dataReader.GetInt32(14);

            ////CODIGO A ELIMINAR (solo para pruebas)
            //string usuario = "";
            //string final = "";
            //usuario += usu.id.ToString() + usu.activo.ToString() + usu.nombre + usu.domicilio;
            //usuario.Trim(); // Borra solo espacios en blanco al inicio/fin de un string
            ////usuario = usuario.Replace(" ", ""); // Reemplaza espacios en blanco segun criterio aplicado
            //final = Regex.Replace(usuario, @"s", ""); // Reemplaza espacios en blanco segun una regular expression

            return usu;
        }
    }

}

