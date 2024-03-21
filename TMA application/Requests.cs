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
            Data.ShowData(@"SELECT
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
                                    Statuses AS S ON R.Status = S.StatusId;", conn, datagrid, connection_string);
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

                    //int p;
                    //if (!int.TryParse(idtext.Text, out p))
                    //{
                    //    MessageBox.Show("id must be a valid integer.");
                    //    return;
                    //}

                    int RequestId = Data.TextToInt(idtext);

                    //string queryitemid = "SELECT ItemId FROM TMARequests WHERE RequestId = @RequestId";
                    //SqlCommand commandItemDirectoryid = new SqlCommand(queryitemid, conn);
                    //commandItemDirectoryid.Parameters.AddWithValue("@RequestId", p);
                    //int q = Convert.ToInt32(commandItemDirectoryid.ExecuteScalar());
                    int Itemid = Data.RetrieveDataIntToInt("SELECT ItemId FROM TMARequests WHERE RequestId = @Value1", conn, connection_string, RequestId);
                    //string queryItemDirectory = "SELECT Quantity FROM ItemDirectory WHERE ItemId = @ItemId";
                    quantity = Data.RetrieveDataIntToInt("SELECT Quantity FROM ItemDirectory WHERE ItemId = @Value1", conn, connection_string, Itemid);
                    //SqlCommand commandItemDirectory = new SqlCommand(queryItemDirectory, conn);



                    //commandItemDirectory.Parameters.AddWithValue("@ItemId", id);
                    //quantity = Convert.ToInt32(commandItemDirectory.ExecuteScalar());

                    tmaRequestsQuantity = Data.RetrieveDataIntToInt("SELECT Quantity FROM TMArequests WHERE RequestId = @Value1", conn, connection_string, RequestId);
                    //string queryTMARequests = "SELECT Quantity FROM TMArequests WHERE RequestId = @RequestId";
                    //SqlCommand commandTMARequests = new SqlCommand(queryTMARequests, conn);
                    //commandTMARequests.Parameters.AddWithValue("@RequestId", p);
                    //tmaRequestsQuantity = Convert.ToInt32(commandTMARequests.ExecuteScalar());

                    if (tmaRequestsQuantity > quantity)
                    {
                        string updatequery1 = "UPDATE TMARequests SET Status = 3 WHERE RequestId = @RequestId";
                        SqlCommand anotherCommand = new SqlCommand(updatequery1, conn);
                        anotherCommand.Parameters.AddWithValue("@RequestId", RequestId);
                        anotherCommand.ExecuteNonQuery();
                        MessageBox.Show("Request quantity is higher than the stored quantity.");
                    }
                    else
                    {
                        string updatequery2 = "UPDATE TMARequests SET Status = 2 WHERE RequestId = @RequestId";
                        SqlCommand anotherCommand = new SqlCommand(updatequery2, conn);
                        anotherCommand.Parameters.AddWithValue("@RequestId", RequestId);
                        anotherCommand.ExecuteNonQuery();
                        

                        string updatequantity = "Update ItemDirectory SET Quantity = @Value1 WHERE ItemId = @ItemId";
                        SqlCommand anotherCommand2 = new SqlCommand(updatequantity, conn);
                        anotherCommand2.Parameters.AddWithValue("@Value1", quantity - tmaRequestsQuantity);
                        anotherCommand2.Parameters.AddWithValue("@ItemId", Itemid);
                        anotherCommand2.ExecuteNonQuery();
                        MessageBox.Show("Request updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
                    string updatequery1 = "UPDATE TMARequests SET Status = 3 WHERE RequestId = @RequestId";
                    SqlCommand anotherCommand = new SqlCommand(updatequery1, conn);
                    int p;
                    if (!int.TryParse(idtext.Text, out p))
                    {
                        MessageBox.Show("id must be a valid integer.");
                        return;
                    }
                    anotherCommand.Parameters.AddWithValue("@RequestId", p);
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
