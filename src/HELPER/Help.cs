using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HELPER
{
    public class Help
    {
        SqlConnection conn; 

        public string connstr;

        public Help(string conexion)
        {
            this.connstr = conexion;
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
    }
}
