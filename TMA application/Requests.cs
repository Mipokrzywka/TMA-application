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

namespace TMA_application
{
    public partial class Requests : Form
    {
        SqlConnection conn;
        string connection_string;
        int quantity;
        int tmaRequestsQuantity;
        public Requests()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void Requests_Load(object sender, EventArgs e)
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
                                    R.RequestId,
                                    R.EmployeeName,
                                    IG.GroupName,
                                    UM.MeasurementName,
                                    R.Quantity, 
                                    R.PriceWithoutVAT, 
                                    S.StatusName AS [Status], 
                                    R.Comment
                                    FROM 
                                    TMARequests AS R
                                    INNER JOIN 
                                    UnitsOfMeasurement AS UM ON UM.MeasurementId = R.UnitOfMeasurement
                                    INNER JOIN 
                                    ItemGroups AS IG ON IG.GroupId = R.ItemId
                                    INNER JOIN 
                                    Statuses AS S ON R.Status = S.StatusId;";
                    
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    string queryitemid = "SELECT ItemId FROM TMARequests WHERE RequestId = @RequestId";
                    SqlCommand commandItemDirectoryid = new SqlCommand(queryitemid, conn);
                    int p;
                    if (!int.TryParse(idtext.Text, out p))
                    {
                        MessageBox.Show("id must be a valid integer.");
                        return;
                    }
                    commandItemDirectoryid.Parameters.AddWithValue("@RequestId", p);
                    int q = Convert.ToInt32(commandItemDirectoryid.ExecuteScalar());
                    string queryItemDirectory = "SELECT Quantity FROM ItemDirectory WHERE ItemId = @ItemId";
                    SqlCommand commandItemDirectory = new SqlCommand(queryItemDirectory, conn);
                    
                    

                    commandItemDirectory.Parameters.AddWithValue("@ItemId", q);
                    quantity = Convert.ToInt32(commandItemDirectory.ExecuteScalar());
                    

                    string queryTMARequests = "SELECT Quantity FROM TMArequests WHERE RequestId = @RequestId";
                    SqlCommand commandTMARequests = new SqlCommand(queryTMARequests, conn);
                    commandTMARequests.Parameters.AddWithValue("@RequestId", p);
                    tmaRequestsQuantity = Convert.ToInt32(commandTMARequests.ExecuteScalar());

                    if (tmaRequestsQuantity > quantity)
                    {
                        string updatequery1 = "UPDATE TMARequests SET Status = 3 WHERE RequestId = @RequestId";
                        SqlCommand anotherCommand = new SqlCommand(updatequery1, conn);
                        anotherCommand.Parameters.AddWithValue("@RequestId", p);
                        anotherCommand.ExecuteNonQuery();
                        MessageBox.Show("Request quantity is higher than the stored quantity.");
                    }
                    else
                    {
                        string updatequery2 = "UPDATE TMARequests SET Status = 2 WHERE RequestId = @RequestId";
                        SqlCommand anotherCommand = new SqlCommand(updatequery2, conn);
                        anotherCommand.Parameters.AddWithValue("@RequestId", p);
                        anotherCommand.ExecuteNonQuery();
                        

                        string updatequantity = "Update ItemDirectory SET Quantity = @Value1 WHERE ItemId = @ItemId";
                        SqlCommand anotherCommand2 = new SqlCommand(updatequantity, conn);
                        anotherCommand2.Parameters.AddWithValue("@Value1", quantity - tmaRequestsQuantity);
                        anotherCommand2.Parameters.AddWithValue("@ItemId", q);
                        anotherCommand2.ExecuteNonQuery();
                        MessageBox.Show("Request updated.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
            ShowData();
        }

        private void reject_button_Click(object sender, EventArgs e)
        {
            using(conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    string updatequery1 = "UPDATE TMARequests SET Status = 3 WHERE ItemId = @ItemId";
                    SqlCommand anotherCommand = new SqlCommand(updatequery1, conn);
                    int p;
                    if (!int.TryParse(idtext.Text, out p))
                    {
                        MessageBox.Show("id must be a valid integer.");
                        return;
                    }
                    anotherCommand.Parameters.AddWithValue("@ItemId", p);
                    anotherCommand.ExecuteNonQuery();
                    MessageBox.Show("Request rejected.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            ShowData();
        }
    }
}
