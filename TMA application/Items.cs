using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TMA_application
{
    public partial class Items : Form
    {
        SqlConnection conn;
        string connection_string;
        public string Id { get; set; }
        public Items()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            datagrid.AutoGenerateColumns = true;
            ShowData();
            
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Id = Id;
            order.Show();
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
                    ON ID.Status = S.StatusId" , conn, datagrid, connection_string);
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
