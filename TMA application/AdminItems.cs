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
        private void CleanText()
        {
            ItemNameTextBox.Text = string.Empty;
            ItemGroupComboBox.SelectedIndex = -1;
            MeasurementComboBox.SelectedIndex = -1;
            QuantityTextbox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            StorageTextBox.Text = string.Empty;
            ContactTextBox.Text = string.Empty;
        }

        private void AdminItems_Load(object sender, EventArgs e)
        {
            datagrid.AutoGenerateColumns = true;
            ShowData();
        }
        private void ShowData()
        {
            Data.ShowData(@"SELECT
                    ID.ItemName,
                    IG.GroupName,
                    UM.MeasurementName,
                    ID.Quantity, 
                    ID.PriceWithoutVAT, 
                    S.StatusName, 
                    ID.StorageLocation, 
                    ID.ContactPerson
                    FROM ItemDirectory ID
                    LEFT JOIN UnitsOfMeasurement UM
                    ON UM.MeasurementID = ID.UnitOfMeasurement
                    LEFT JOIN ItemGroups IG
                    ON IG.GroupId = ID.ItemGroup
                    LEFT JOIN Statuses S
                    ON ID.Status = S.StatusId", conn, datagrid, connection_string);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
          SqlConnection conn = null;
            
            try
            {
                using (conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = "INSERT INTO ItemDirectory(ItemName,ItemGroup, UnitOfMeasurement, Quantity, PriceWithoutVAT, Status, StorageLocation, ContactPerson) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, 4, @Value6, @Value7)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Value1", ItemNameTextBox.Text);
                    command.Parameters.AddWithValue("@Value2", ItemGroupComboBox.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@Value3", MeasurementComboBox.SelectedIndex + 1);
                    int q = Data.TextToInt(QuantityTextbox);
                    command.Parameters.AddWithValue("@Value4", q);
                    decimal p = Data.TextToDecimal(PriceTextBox);
                    command.Parameters.AddWithValue("@Value5", p);
                    command.Parameters.AddWithValue("@Value6", StorageTextBox.Text);
                    command.Parameters.AddWithValue("@Value7", ContactTextBox.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully.");
                    ShowData();
                    CleanText();
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
                                    SET 
                                    Quantity = @Value3,
                                    PriceWithoutVAT = @Value4,
                                    StorageLocation = @Value5,
                                    ContactPerson = @Value6
                                    WHERE ItemId = @Value7";
                    SqlCommand command = new SqlCommand(query, conn);
                    int q = Data.TextToInt(QuantityTextbox);
                    command.Parameters.AddWithValue("@Value3", q);
                    decimal p = Data.TextToDecimal(PriceTextBox);
                    command.Parameters.AddWithValue("@Value4", p);
                    command.Parameters.AddWithValue("@Value5", StorageTextBox.Text);
                    command.Parameters.AddWithValue("@Value6", ContactTextBox.Text);
                    int id = Data.TextToInt(IdTextBox);
                    command.Parameters.AddWithValue("@Value7", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully.");

                    ShowData();
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
                    if (!int.TryParse(IdTextBox.Text, out q))
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
