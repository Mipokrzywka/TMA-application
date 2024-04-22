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
        string storedString;
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
                                    R.RequestId AS ID,
                                    R.EmployeeName AS Employee,
                                    I.ItemName,
                                    IG.GroupName,
                                    UM.MeasurementName,
                                    R.Quantity, 
                                    I.PriceWithoutVAT * R.Quantity AS PriceWithoutVAT, 
                                    S.StatusName AS [Status], 
                                    R.Comment
                                    FROM 
                                    TMARequests AS R
                                    LEFT JOIN
                                    ItemDirectory AS I ON R.ItemId = I.ItemId
                                    LEFT JOIN 
                                    UnitsOfMeasurement AS UM ON UM.MeasurementId = I.UnitOfMeasurement
                                    LEFT JOIN 
                                    ItemGroups AS IG ON IG.GroupId = I.ItemGroup
                                    LEFT JOIN 
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
                    int RequestId = Data.TextToInt(idtext);
                    conn.Open();
                    string query1 = "SELECT Status FROM TMARequests WHERE RequestID = @Value1";
                    int status = Data.RetrieveDataIntToInt(query1, conn, connection_string, RequestId);
                    if(status == 2)
                    {
                        MessageBox.Show("The request is already approved");
                        conn.Close();
                    }
                    else 
                    { 
                        try
                        {
                            int Itemid = Data.RetrieveDataIntToInt("SELECT ItemId FROM TMARequests WHERE RequestId = @Value1", conn, connection_string, RequestId);
                            quantity = Data.RetrieveDataIntToInt("SELECT Quantity FROM ItemDirectory WHERE ItemId = @Value1", conn, connection_string, Itemid);
                            tmaRequestsQuantity = Data.RetrieveDataIntToInt("SELECT Quantity FROM TMArequests WHERE RequestId = @Value1", conn, connection_string, RequestId);
                            int diff = quantity - tmaRequestsQuantity;
                            if (tmaRequestsQuantity > quantity)
                            {
                                string updatequery1 = "UPDATE TMARequests SET Status = @Value1 WHERE RequestId = @Value2";
                                Data.Update(updatequery1, conn, connection_string, 3, RequestId);
                                MessageBox.Show("Request quantity is higher than the stored quantity.");
                            }
                            else
                            {
                                string updatequery2 = "UPDATE TMARequests SET Status = @Value1 WHERE RequestId = @Value2";
                                Data.Update(updatequery2, conn, connection_string, 2, RequestId);                     

                                string updatequantity = "UPDATE ItemDirectory SET Quantity = @Value1 WHERE ItemId = @Value2";
                                Data.Update(updatequantity, conn, connection_string, diff, Itemid);
                                MessageBox.Show("Request updated.");
                            }
                            if(quantity == 0 || diff == 0)
                            {
                                string query = "UPDATE ItemDirectory SET Status = @Value1 WHERE ItemId = @Value2";
                                Data.Update(query, conn, connection_string, 5, Itemid);
                                MessageBox.Show("A refill needed");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
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
            CommentRequests commentRequests = new CommentRequests();
            commentRequests.ReturnString += ChildForm_StringEntered;
            commentRequests.ShowDialog();

            using (conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE TMARequests SET Status = 3, Comment = @Value1 WHERE RequestId = @Value2";
                    int p = Data.TextToInt(idtext);
                    Data.Update(query, conn, connection_string, storedString, p);
                    MessageBox.Show("Request rejected.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            ShowData();
        }
        private void ChildForm_StringEntered(object sender, string enteredString)
        {
            storedString = enteredString;
        }

            private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
