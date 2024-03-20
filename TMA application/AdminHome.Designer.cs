namespace TMA_application
{
    partial class AdminHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.items_button = new System.Windows.Forms.Button();
            this.requests_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 120);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(408, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TMA Warehouse";
            // 
            // items_button
            // 
            this.items_button.BackColor = System.Drawing.Color.Wheat;
            this.items_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.items_button.Location = new System.Drawing.Point(195, 329);
            this.items_button.Name = "items_button";
            this.items_button.Size = new System.Drawing.Size(272, 174);
            this.items_button.TabIndex = 2;
            this.items_button.Text = "ITEMS";
            this.items_button.UseVisualStyleBackColor = false;
            this.items_button.Click += new System.EventHandler(this.items_button_Click);
            // 
            // requests_button
            // 
            this.requests_button.BackColor = System.Drawing.Color.Wheat;
            this.requests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.requests_button.Location = new System.Drawing.Point(679, 329);
            this.requests_button.Name = "requests_button";
            this.requests_button.Size = new System.Drawing.Size(272, 174);
            this.requests_button.TabIndex = 3;
            this.requests_button.Text = "REQUESTS";
            this.requests_button.UseVisualStyleBackColor = false;
            this.requests_button.Click += new System.EventHandler(this.requests_button_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.requests_button);
            this.Controls.Add(this.items_button);
            this.Controls.Add(this.panel1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button items_button;
        private System.Windows.Forms.Button requests_button;
    }
}