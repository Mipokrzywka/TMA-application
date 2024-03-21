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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Requests re = new Requests();
            re.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            AdminItems items = new AdminItems();
            items.Show();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
             panel3.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(39, 43, 68);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(39, 43, 68);
        }

        private void items_Click(object sender, EventArgs e)
        {
            AdminItems items = new AdminItems();
            items.Show();
        }

        private void requests_Click(object sender, EventArgs e)
        {
            Requests re = new Requests();
            re.Show();
        }
        private void AdminHome_Resize(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
        }
    }
}
