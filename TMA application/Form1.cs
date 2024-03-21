using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            RoundCorners(panel1, 20);
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

        private void RoundCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); 
            path.AddArc(control.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90); 
            path.AddArc(control.Width - (radius * 2), control.Height - (radius * 2), radius * 2, radius * 2, 0, 90); 
            path.AddArc(0, control.Height - (radius * 2), radius * 2, radius * 2, 90, 90); 
            path.CloseFigure();

            control.Region = new Region(path);
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
        private void login_button_MouseEnter(object sender, EventArgs e)
        {
            login_button.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void login_button_MouseLeave(object sender, EventArgs e)
        {
            login_button.BackColor = Color.FromArgb(175, 194, 225);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.FromArgb(78, 93, 167);
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.FromArgb(175, 194, 225);
        }

        private void user_textbox_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
