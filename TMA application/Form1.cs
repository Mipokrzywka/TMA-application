using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        string password = "";
        string Role = "";
        string connection_string;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            connection_string = ConfigurationManager.ConnectionStrings["TMA_application.Properties.Settings.Database1ConnectionString"].ConnectionString;
            RoundCorners(panel1, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string Id = user_textbox.Text;
            string pass = password_textbox.Text;
            using (conn = new SqlConnection(connection_string))
                try
                {
                    conn.Open();
                    string query = @"SELECT Role, Password FROM Users
                                    WHERE username = @value1";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@value1", user_textbox.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        password = reader["Password"].ToString();
                        Role = reader["Role"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
                password = Cipher.CipherOut(password);

            if (Role == "2" && pass == password)
            {
                Items items = new Items();
                items.Id = Id;
                items.Show();
            }
            else if (Role == "1" && pass == password)
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
