using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public static int TextToInt(System.Windows.Forms.TextBox textbox)
        {
            int id;
            if (!int.TryParse(textbox.Text, out id))
            {
                MessageBox.Show("The data inputted in " + textbox.Name + " must be a valid integer");
                return -1;
            }
            return id;
        }
        public static decimal TextToDecimal(System.Windows.Forms.TextBox textbox)
        {
            decimal dec;
            if(!decimal.TryParse(textbox.Text, out dec))
            {
                MessageBox.Show("The data inputted in " + textbox.Name + " must be a valid integer");
                return -1;
            }
            return dec;
        }
        public static void Update(string query, SqlConnection conn, string connection_string,int value1, int value2)
        {
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Value1", value1);
            command.Parameters.AddWithValue("@Value2", value2);
            command.ExecuteNonQuery();
        }
    }
}
