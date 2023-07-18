using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TechTalk2023.DBEngine
{
    public class SQLServerHandler
    {
        private SqlConnection conn = null;

        public SQLServerHandler()
        {
            string _conString = ConfigurationManager.AppSettings["ConnString"];
            conn = new SqlConnection(_conString);
            conn.Open();
        }

        public object ExecuteScalar(string Query)
        {
            object result = null;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Query;
                cmd.CommandType = CommandType.Text;

                result = cmd.ExecuteScalar();
                cmd.Dispose();
                //conn.Dispose();
            }
            catch (Exception ex)
            {

            }

            return result;

        }
        public DataTable ExecuteTable(string Query)
        {
            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dataTable);
            //conn.Close(); 
            //conn.Dispose(); 
            return dataTable;
        }
        public int ExecuteNonQuery(string Query)
        {
            int result = 0;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Query;
                cmd.CommandType = CommandType.Text;

                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                //conn.Dispose();
            }
            catch (Exception ex)
            {

            }

            return result;

        }



        public void Dispose()
        {
            conn.Dispose();
            conn.Close();
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}