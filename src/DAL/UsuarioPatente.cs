using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data;

namespace DAL
{
    public class UsuarioPatente : BE.ICRUD<BE.UsuarioPatente>
    {
        public static HELPER.Help helper = new HELPER.Help();

        public int Add(BE.UsuarioPatente objAlta)
        {
            string query = "INSERT INTO UsuarioPatente VALUES(" + objAlta.id_patente + "," + objAlta.id_usuario + "," + objAlta.DVH + "," + Convert.ToInt32(objAlta.patenteNegada) + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.UsuarioPatente objBaja)
        {
            string query = "DELETE from UsuarioPatente where id_patente = " + objBaja.id_patente + " and id_usuario = " + objBaja.id_usuario + "";
            return helper.ExecuteNonQuery(query);
        }

        public int Update(BE.UsuarioPatente objUpdate)
        {
            string query = "UPDATE UsuarioPatente SET DVH = " + objUpdate.DVH + "," + " patenteNegada = "  + Convert.ToInt32(objUpdate.patenteNegada) + " where id_patente =" + objUpdate.id_patente + " and id_usuario =" + objUpdate.id_usuario + "";
            return helper.ExecuteNonQuery(query);
        }

        public List<BE.UsuarioPatente> SelectAll()
        {
            string query = "SELECT * from UsuarioPatente";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.UsuarioPatente> usuPatList = new List<BE.UsuarioPatente>();
                while (dataReader.Read())
                {
                    BE.UsuarioPatente usuPatentes = MapDataReaderUsuPat(dataReader);
                    usuPatList.Add(usuPatentes);
                }

                return usuPatList;
            }
        }

        public List<BE.UsuarioPatente> SelectByIdUser(int idUsuario)
        {
            //string query = $"Select * From UsuarioPatente where Id = {id}";
            string query = "Select * From UsuarioPatente where id_usuario =" + idUsuario + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.UsuarioPatente> usuPat = new List<BE.UsuarioPatente>();
                while (dataReader.Read())
                {
                    BE.UsuarioPatente usuarioPatentes = MapDataReaderUsuPat(dataReader);
                    usuPat.Add(usuarioPatentes);
                }

                return usuPat;
            }
        }

        public BE.UsuarioPatente GetUsuarioPatente(int idUsuario, int idPatente) 
        {
            string query = "Select * From UsuarioPatente where id_usuario =" + idUsuario + " AND id_patente = " + idPatente + "";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                BE.UsuarioPatente usuPat = new BE.UsuarioPatente();
                while (dataReader.Read())
                {
                    usuPat = MapDataReaderUsuPat(dataReader);
                }

                return usuPat;
            }
        }

        //NOTA: retornar una lista sin repetir de las patentes del usuario (sólo las individuales)
        public List<BE.Patente> GetPatentesIndividuales(int id_usuario)
        {
            string query = "SELECT Patente.id_patente, Patente.descripcion, Patente.activo FROM UsuarioPatente INNER JOIN Patente ON UsuarioPatente.id_patente = Patente.id_patente WHERE id_usuario =" + id_usuario + ""; 
            //string query = $"SELECT Patente.id_patente, Patente.descripcion, Patente.activo FROM UsuarioPatente INNER JOIN Patente ON UsuarioPatente.id_patente = Patente.id_patente WHERE id_usuario = {id_usuario}";
            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Patente> patente_list = new List<BE.Patente>();
                while (dataReader.Read())
                {
                    BE.Patente usuarioPatentes = MapDataReaderPat(dataReader);
                    patente_list.Add(usuarioPatentes);
                }

                return patente_list;
            }
        }

        //NOTA: retornar una lista sin repetir de las patentes del usuario (individuales + familia)
        public List<BE.Patente> GetPatentesUsuario(int id_usuario)
        {
            string query = @"declare @idUsuario Int = " + id_usuario + @"
                            select distinct up.id_patente, p.descripcion, p.activo
                            from usuario u
                            INNER JOIN UsuarioPatente up on u.id_usuario = up.id_usuario
                            INNER JOIN Patente p on up.id_patente = p.id_patente
                            where u.id_usuario = @idUsuario
                            UNION
                            select distinct p.id_patente, p. descripcion, p.activo
                            from usuario u
                            INNER JOIN FamiliaUsuario fu on u.id_usuario = fu.id_usuario
                            INNER JOIN Familia f on fu.id_familia = f.id_familia
                            INNER JOIN FamiliaPatente fp on fu.id_familia = fp.id_familia
                            INNER JOIN Patente p on fp.id_patente = p.id_patente
                            where u.id_usuario = @idUsuario";

            using (SqlDataReader dataReader = helper.ExecuteReader(query))
            {
                List<BE.Patente> patente_list = new List<BE.Patente>();
                while (dataReader.Read())
                {
                    BE.Patente usuarioPatentes = MapDataReaderPat(dataReader);
                    patente_list.Add(usuarioPatentes);
                }

                return patente_list;
            }
        }

        /*************************************************************************/
        private BE.UsuarioPatente MapDataReaderUsuPat(SqlDataReader dataReader) {
            BE.UsuarioPatente usuPat = new BE.UsuarioPatente();
            usuPat.id_patente = dataReader.GetInt32(0);
            usuPat.id_usuario = dataReader.GetInt32(1);
            usuPat.DVH = dataReader.GetInt32(2);
            usuPat.patenteNegada = dataReader.GetBoolean(3);

            return usuPat;
        }

        private BE.Patente MapDataReaderPat(SqlDataReader dataReader)
        {
            BE.Patente patente = new BE.Patente();
            patente.id = dataReader.GetInt32(0);
            patente.descripcion = dataReader.GetString(1);
            patente.activo = dataReader.GetBoolean(2);

            return patente;
        }
    }
}
