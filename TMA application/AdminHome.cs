using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMA_application
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void items_button_Click(object sender, EventArgs e)
        {
            AdminItems items = new AdminItems();
            items.Show();
        }

        private void requests_button_Click(object sender, EventArgs e)
        {
            Requests re = new Requests();
            re.Show();
        }
    }
}
