using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class FamiliaUsuario : BE.ICRUD<BE.FamiliaUsuario>
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.FamiliaUsuario objAlta)
        {
            string query = "INSERT INTO FamiliaUsuario VALUES(" + objAlta.id_usuario + "," + objAlta.id_familia + "" + ")";
            Console.WriteLine(query);
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.FamiliaUsuario objBaja)
        {
            string query = "DELETE from FamiliaUsuario where id_usuario = " + objBaja.id_usuario + " and id_familia = " + objBaja.id_familia + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.FamiliaUsuario objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaUsuario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.FamiliaUsuario> SelectByIdUser(int idUsuario)
        {
            //string query = $"Select * From UsuarioPatente where Id = {id}";
            string query = "Select * From FamiliaUsuario where id_usuario =" + idUsuario + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.FamiliaUsuario> usuFam = new List<BE.FamiliaUsuario>();
                while (dataReader.Read())
                {
                    BE.FamiliaUsuario usuarioFamilias = MapDataReaderUsuFam(dataReader);
                    usuFam.Add(usuarioFamilias);
                }

                return usuFam;
            }
        }

        public List<BE.Familia> GetFamilias(int idUsuario) 
        {
            string query = "SELECT Familia.id_familia, Familia.descripcion, Familia.activo FROM FamiliaUsuario INNER JOIN Familia ON FamiliaUsuario.id_familia = Familia.id_familia WHERE id_usuario = "+idUsuario+"";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Familia> familia_list = new List<BE.Familia>();
                while (dataReader.Read())
                {
                    BE.Familia familiaUsuario = MapDataReaderFam(dataReader);
                    familia_list.Add(familiaUsuario);
                }

                return familia_list;
            }
        }

        public List<BE.Usuario> GetFamiliaUsuario(int id_familia)
        {
            string query = "SELECT * FROM Usuario u INNER JOIN FamiliaUsuario fu on fu.id_usuario = u.id_usuario WHERE fu.id_familia = " + id_familia + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Usuario> usu_list = new List<BE.Usuario>();
                while (dataReader.Read())
                {
                    BE.Usuario familiaUsuario = MapDataReaderUsuario(dataReader);
                    usu_list.Add(familiaUsuario);
                }

                return usu_list;
            }
        }

        private BE.FamiliaUsuario MapDataReaderUsuFam(SqlDataReader dataReader)
        {
            BE.FamiliaUsuario familiaUsuario = new BE.FamiliaUsuario();
            familiaUsuario.id_usuario = dataReader.GetInt32(0);
            familiaUsuario.id_familia = dataReader.GetInt32(1);

            return familiaUsuario;
        }

        private BE.Familia MapDataReaderFam(SqlDataReader dataReader)
        {
            BE.Familia familia = new BE.Familia();
            familia.id = dataReader.GetInt32(0);
            familia.descripcion = dataReader.GetString(1);
            familia.activo = dataReader.GetBoolean(2);

            return familia;
        }

        private BE.Usuario MapDataReaderUsuario(SqlDataReader dataReader)
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
            usu.contraseña = dataReader.GetString(9);
            usu.cant_ingresos_incorrectos = dataReader.GetInt32(10);
            usu.DVH = dataReader.GetInt32(11);
            usu.es_primer_login = dataReader.GetBoolean(12);
            usu.id_idioma = dataReader.GetInt32(13);

            return usu;
        }
    }
}
