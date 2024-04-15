using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMA_application
{
    internal class Data
    {
        public static void ShowData(string query, SqlConnection conn, DataGridView datagrid, string connection_string)
        {
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                        datagrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public static int RetrieveDataInt(string query, SqlConnection conn, TextBox textbox,  string connection_string)
        //{
        //    int p;
        //    if (!int.TryParse(textbox.Text, out p))
        //    {
        //        MessageBox.Show("id must be a valid integer.");
        //        return -1;
        //    }
        //    SqlCommand command = new SqlCommand(query, conn);
        //    command.Parameters.AddWithValue("@RequestId", p);
        //    int q = Convert.ToInt32(command.ExecuteScalar());
        //    return q;
        //}
        public static string RetrieveDataString(string query, SqlConnection conn, TextBox textbox, string connection_string)
        {
            int p = TextToInt(textbox);
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@RequestId", p);
            string q = command.ExecuteScalar().ToString();
            return q;
        }
        public static int RetrieveDataIntToInt(string query, SqlConnection conn, string connection_string, int id)
        {
            int quantity;
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Value1", id);
            quantity = Convert.ToInt32(command.ExecuteScalar());
            return quantity;
        }
        public static void UpdateDataShort(int count, string query, SqlConnection conn, TextBox text1, TextBox text2 = null, TextBox text3 = null, TextBox text4 = null, TextBox text5 = null, TextBox text6 = null, TextBox text7 = null) 
        {
            SqlCommand command = new SqlCommand(query,conn);
            for(int i = 1; i < count+1;i++)
            {
                command.Parameters.AddWithValue("@Value"+i,text$i)
            }
        }
        public static int TextToInt(TextBox textbox)
        {
            int id;
            if (!int.TryParse(textbox.Text, out id))
            {
                MessageBox.Show("id must be a valid integer.");
                return -1;
            }
            return id;
        }
    }
}
