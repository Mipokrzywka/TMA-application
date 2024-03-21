using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TMA_application
{
    public partial class Order : Form
    {
        SqlConnection conn;
        string connection_string;
        public string Id { get; set; }
        public Order()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void Order_Load(object sender, EventArgs e)
        {
        }

        private void unitofmeasurement_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conn = null;

                try
                {
                    using (conn = new SqlConnection(connection_string))
                    {
                        conn.Open();
                        string query = "INSERT INTO TMARequests(EmployeeName, ItemId, UnitOfMeasurement, Quantity, PriceWithoutVAT, Comment) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@Value1", Id);
                        int q;
                        if (!int.TryParse(item_name_textbox.Text, out q))
                        {
                            MessageBox.Show("ItemId must be a valid integer.");
                            return;
                        }
                        command.Parameters.AddWithValue("@Value2", q);


                        command.Parameters.AddWithValue("@Value3", unitofmeasurement_combobox.SelectedIndex + 1);

                        int p;
                        if (!int.TryParse(quantity_textbox.Text, out p))
                        {
                            MessageBox.Show("Quantity must be a valid integer.");
                            return;
                        }
                        command.Parameters.AddWithValue("@Value4", p);
                        decimal s;
                        if (!decimal.TryParse(price_textbox.Text, out s))
                        {
                            MessageBox.Show("Price must be a valid decimal.");
                            return;
                        }

                        command.Parameters.AddWithValue("@Value5", s);
                        command.Parameters.AddWithValue("@Value6", comment_textbox.Text);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                        conn.Close();
                        this.Close();
                        MessageBox.Show("Request created");
                }
            }
            
        }
    }
}
