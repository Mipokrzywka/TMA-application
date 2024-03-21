namespace TMA_application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.user_textbox = new System.Windows.Forms.TextBox();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.password_textbox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.password_textbox.Location = new System.Drawing.Point(50, 261);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(409, 34);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // user_textbox
            // 
            this.user_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.user_textbox.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.user_textbox.Location = new System.Drawing.Point(50, 188);
            this.user_textbox.Name = "user_textbox";
            this.user_textbox.Size = new System.Drawing.Size(409, 34);
            this.user_textbox.TabIndex = 4;
            this.user_textbox.Click += new System.EventHandler(this.user_textbox_Click);
            this.user_textbox.TextChanged += new System.EventHandler(this.user_textbox_TextChanged);
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.show_password.Location = new System.Drawing.Point(49, 356);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(185, 27);
            this.show_password.TabIndex = 2;
            this.show_password.Text = "Show password";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.login_button.Location = new System.Drawing.Point(289, 464);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(169, 62);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            this.login_button.MouseEnter += new System.EventHandler(this.login_button_MouseEnter);
            this.login_button.MouseLeave += new System.EventHandler(this.login_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "TMA Warehouse";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.show_password);
            this.panel1.Controls.Add(this.user_textbox);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Location = new System.Drawing.Point(314, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 599);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.label3.Location = new System.Drawing.Point(213, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(210, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.exit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.exit_button.Location = new System.Drawing.Point(49, 464);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(169, 62);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::TMA_application.Properties.Resources.warehouse;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 732);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox user_textbox;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

