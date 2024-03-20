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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string Id = user_textbox.Text;
            string pass = password_textbox.Text;

            if (Id == "User1" && pass == "passwd")
            {
                Items items = new Items();
                items.Id = Id;
                items.Show();
            }
            else if (Id == "Admin1" && pass == "adminpasswd")
            {
                AdminHome h = new AdminHome();
                h.Show();
            }
            else if (Id == "" || pass == "")
            {
                MessageBox.Show("Please input your login and password.");
            }
            else
            {
                MessageBox.Show("Wrong login or password, please try again.");
            }
        }

        private void user_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            password_textbox.UseSystemPasswordChar = (password_textbox.UseSystemPasswordChar == true) ? false : true;
        }
    }
}
