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
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace TMA_application
{
    public partial class AdminItems : Form
    {
        SqlConnection conn;
        string connection_string;
        int Id;
        int DataId;
        public AdminItems()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }
        private void CleanText()
        {
            try
            {
                ItemNameTextBox.Text = string.Empty;
                ItemGroupComboBox.SelectedIndex = -1;
                MeasurementComboBox.SelectedIndex = -1;
                QuantityTextbox.Text = string.Empty;
                PriceTextBox.Text = string.Empty;
                StorageTextBox.Text = string.Empty;
                ContactTextBox.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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
                Data.ShowData(@"SELECT
                    ID.ItemId,
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
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
                    string query = @"BEGIN TRANSACTION;
                                    INSERT INTO ItemDirectory(ItemName,ItemGroup, UnitOfMeasurement, Quantity, PriceWithoutVAT, Status, StorageLocation, ContactPerson) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, 4, @Value6, @Value7);
                                    COMMIT";
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
                    string query = @"BEGIN TRANSACTION;
                                    UPDATE ItemDirectory 
                                    SET 
                                    Quantity = @Value3,
                                    PriceWithoutVAT = @Value4,
                                    StorageLocation = @Value5,
                                    ContactPerson = @Value6
                                    WHERE ItemId = @Value7;
                                    COMMIT;";
                    SqlCommand command = new SqlCommand(query, conn);
                    int q = Data.TextToInt(QuantityTextbox);
                    command.Parameters.AddWithValue("@Value3", q);
                    decimal p = Data.TextToDecimal(PriceTextBox);
                    command.Parameters.AddWithValue("@Value4", p);
                    command.Parameters.AddWithValue("@Value5", StorageTextBox.Text);
                    command.Parameters.AddWithValue("@Value6", ContactTextBox.Text);
                    command.Parameters.AddWithValue("@Value7", DataId);
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
                    string query = @"BEGIN TRANSACTION;
                                    DELETE FROM ItemDirectory WHERE ItemId = @Value1;
                                    COMMIT;";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Value1", DataId);
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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_button_MouseLeave(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FromArgb(175, 194, 225);
        }

        private void update_button_MouseLeave(object sender, EventArgs e)
        {
            update_button.BackColor = Color.FromArgb(175, 194, 225);
        }

        private void delete_button_MouseLeave(object sender, EventArgs e)
        {
            delete_button.BackColor = Color.FromArgb(175, 194, 225);
        }

        private void add_button_MouseEnter(object sender, EventArgs e)
        {
            add_button.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void update_button_MouseHover(object sender, EventArgs e)
        {
            update_button.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void delete_button_MouseHover(object sender, EventArgs e)
        {
            delete_button.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Id = datagrid.CurrentCell.RowIndex;
                DataId = (int)(datagrid.Rows[Id].Cells[0].Value);
                ItemNameTextBox.Text = datagrid.Rows[Id].Cells[1].Value.ToString();
                switch (datagrid.Rows[Id].Cells[2].Value.ToString())
                {
                    case "Electronics":
                        ItemGroupComboBox.SelectedIndex = 0;
                        break;
                    case "Clothing":
                        ItemGroupComboBox.SelectedIndex = 1;
                        break;
                    case "Furniture":
                        ItemGroupComboBox.SelectedIndex = 2;
                        break;
                    case "Appliances":
                        ItemGroupComboBox.SelectedIndex = 3;
                        break;
                    default:
                        ItemGroupComboBox.SelectedIndex = -1;
                        break;
                }
                switch (datagrid.Rows[Id].Cells[3].Value.ToString())
                {
                    case "Piece":
                        MeasurementComboBox.SelectedIndex = 0;
                        break;
                    case "Box":
                        MeasurementComboBox.SelectedIndex = 1;
                        break;
                    case "Set":
                        MeasurementComboBox.SelectedIndex = 2;
                        break;
                    case "Pair":
                        MeasurementComboBox.SelectedIndex = 3;
                        break;
                    default:
                        MeasurementComboBox.SelectedIndex = -1;
                        break;
                }
                QuantityTextbox.Text = datagrid.Rows[Id].Cells[4].Value.ToString();
                PriceTextBox.Text = datagrid.Rows[Id].Cells[5].Value.ToString();
                StorageTextBox.Text = datagrid.Rows[Id].Cells[7].Value.ToString();
                ContactTextBox.Text = datagrid.Rows[Id].Cells[8].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
