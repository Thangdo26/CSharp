using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QLHD_QC_VB.Class
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string stringconn;
        public static void Connect()
        {
            stringconn = "Data Source=THANGDO;Initial Catalog=db_BTLC#;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = stringconn;
            conn.Open();
            MessageBox.Show("Ket noi thanh cong!");
        }
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand(sql,Functions.conn);
            mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static bool checkkey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Class.Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
        public static void runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql);
            cmd.Connection = Class.Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static object GetSingleValue(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Class.Functions.conn;
            command.CommandText = sql;

            // Assume the connection is already opened outside this method
            try
            {
                object result = command.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, or return a default value)
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
