using System;
using System.Collections;
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

namespace TMA_application
{
    public partial class AdminItems : Form
    {
        SqlConnection conn;
        string connection_string;
        public AdminItems()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void AdminItems_Load(object sender, EventArgs e)
        {
            datagrid.AutoGenerateColumns = true;
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    string query = @"SELECT
                    ID.ItemId,
                    IG.GroupName,
                    UM.MeasurementName,
                    ID.Quantity, 
                    ID.PriceWithoutVAT, 
                    ID.Status, 
                    ID.StorageLocation, 
                    ID.ContactPerson
                    FROM ItemDirectory ID
                    INNER JOIN UnitsOfMeasurement UM
                    ON UM.MeasurementID = ID.UnitOfMeasurement
                    INNER JOIN ItemGroups IG
                    ON IG.GroupId = ID.ItemGroup";
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

        private void add_button_Click(object sender, EventArgs e)
        {
          SqlConnection conn = null;
            
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "INSERT INTO ItemDirectory(ItemGroup, UnitOfMeasurement, Quantity, PriceWithoutVAT, Status, StorageLocation, ContactPerson) VALUES (@Value1, @Value2, @Value3, @Value4, 'Available', @Value5, @Value6)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Value1", group.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@Value2", measure.SelectedIndex + 1);

                    int q;
                    if (!int.TryParse(textBox3.Text, out q))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value3", q);

                    decimal p;
                    if (!decimal.TryParse(textBox4.Text, out p))
                    {
                        MessageBox.Show("Price must be a valid decimal.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value4", p);

                    command.Parameters.AddWithValue("@Value5", textBox5.Text);
                    command.Parameters.AddWithValue("@Value6", textBox6.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully.");
                    ShowData();
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
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = @"UPDATE ItemDirectory 
                                    SET ItemGroup = @Value1,
                                    UnitOfMeasurement = @Value2,
                                    Quantity = @Value3,
                                    PriceWithoutVAT = @Value4,
                                    StorageLocation = @Value5,
                                    ContactPerson = @Value6
                                    WHERE ItemId = @Value7";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Value1", group.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@Value2", measure.SelectedIndex + 1);

                    int q;
                    if (!int.TryParse(textBox3.Text, out q))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value3", q);

                    decimal p;
                    if (!decimal.TryParse(textBox4.Text, out p))
                    {
                        MessageBox.Show("Price must be a valid decimal.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value4", p);

                    command.Parameters.AddWithValue("@Value5", textBox5.Text);
                    command.Parameters.AddWithValue("@Value6", textBox6.Text);
                    int s;
                    if (!int.TryParse(id_text.Text, out s))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value7", s);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully.");
                        ShowData();
                    }
                    else
                    {
                        MessageBox.Show("Item not found or could not be updated.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = @"DELETE FROM ItemDirectory WHERE ItemId = @Value1";
                    SqlCommand command = new SqlCommand(query, conn);
                    int q;
                    if (!int.TryParse(id_text.Text, out q))
                    {
                        MessageBox.Show("Quantity must be a valid integer.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Value1", q);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item deleted successfully.");
                        ShowData();
                    }
                    else
                    {
                        MessageBox.Show("No items deleted. Item with specified ID not found.");
                    }
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
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
