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
    public partial class CommentRequests : Form
    {
        public event EventHandler<string> ReturnString;
        public CommentRequests()
        {
            InitializeComponent();
        }

        private void CommentRequests_Load(object sender, EventArgs e)
        {
            
        }

        private void Comment_TextChanged(object sender, EventArgs e)
        {  
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (Comment.Text != string.Empty) 
            { 
                string text = Comment.Text;
                ReturnString?.Invoke(this, text);
                this.Close();
            }
            else
            {
                MessageBox.Show("A comment on why the request is rejected must be inputted.");
                return;
            }
        }
    }
}
