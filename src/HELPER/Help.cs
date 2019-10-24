using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace HELPER
{
    public class Help
    {
        SqlConnection conn; 

        private static string _connstr;

        public static string connstr
        {
            get 
            {
                if (string.IsNullOrEmpty(_connstr))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(@"C:\\Hotel Yavin\\Connection_string.xml");
                    XmlNodeList nodos;
                    nodos = doc.GetElementsByTagName("conexionBD");
                    foreach (XmlNode nodo in nodos)
                    {
                        //FALTA DESENCRIPTAR
                        _connstr = nodo.SelectSingleNode("connectionString").InnerText;
                    }
                }

                return _connstr; 
            }
            set { _connstr = value; }
        }
        

        public int ExecuteNonQuery(string query)
        {

            using (conn = new SqlConnection(connstr))
            {
                SqlCommand comm = new SqlCommand(query, conn);
                conn.Open();

                return comm.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query)
        {

            using (conn = new SqlConnection(connstr))
            {
                SqlCommand comm = new SqlCommand(query, conn);
                conn.Open();

                return comm.ExecuteScalar();
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            SqlDataReader reader;

            //using (SqlConnection conn = new SqlConnection(connstr))
            //{
            conn = new SqlConnection(connstr);
            SqlCommand comm = new SqlCommand(query, conn);
            conn.Open();

            reader = comm.ExecuteReader();
                //reader.Read();

            //    //DataTable tabla = new DataTable();
            //    //int columnsNumber = reader.FieldCount;
            //    //for (int i = 0; i < columnsNumber; i++)
            //    //{
            //    //    tabla.Columns
            //    //}
            return reader;         
        }

        public Boolean ValidarConexion(string str)
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Se conectó a la BD"); 
                    }
                    else
                    {
                        Console.WriteLine("Hubo un error en la conexión a la BD");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un error en la conexión a la BD");
            }
            
        }
    }
}
