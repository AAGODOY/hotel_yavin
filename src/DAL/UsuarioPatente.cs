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
        public static HELPER.Help helper = new HELPER.Help(@"Data Source=ALDANA-PC\ALDANA_GODOY;Initial Catalog=HotelYavin;Integrated Security=True");
        //public static HELPER.Help helper = new HELPER.Help(@"Data Source=KB33\SQL_EAC;Initial Catalog=HotelYavin;Integrated Security=True");

        public int Add(BE.UsuarioPatente objAlta)
        {
            string query = "INSERT INTO UsuarioPatente VALUES(" + objAlta.id_patente + "," + objAlta.id_usuario + "," + objAlta.DVH + "," + Convert.ToInt32(objAlta.patenteNegada) + "" + ")";
            return helper.ExecuteNonQuery(query);
        }

        public int Delete(BE.UsuarioPatente objBaja)
        {
            throw new NotImplementedException();
        }

        public int Update(BE.UsuarioPatente objUpdate)
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<BE.UsuarioPatente> SelectById(int id)
        {
            //string query = $"Select * From UsuarioPatente where Id = {id}";
            string query = "Select * From UsuarioPatente where Id =" + id + "";
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

        public List<BE.Patente> GetPatentes(int id_usuario)
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
