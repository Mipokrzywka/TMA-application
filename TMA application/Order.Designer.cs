namespace TMA_application
{
    partial class Order
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.item_name_textbox = new System.Windows.Forms.TextBox();
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.comment_textbox = new System.Windows.Forms.RichTextBox();
            this.unitofmeasurement_combobox = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 120);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(270, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Of Measurement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price without VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comment";
            // 
            // item_name_textbox
            // 
            this.item_name_textbox.Location = new System.Drawing.Point(332, 199);
            this.item_name_textbox.Name = "item_name_textbox";
            this.item_name_textbox.Size = new System.Drawing.Size(367, 26);
            this.item_name_textbox.TabIndex = 7;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Location = new System.Drawing.Point(332, 333);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(367, 26);
            this.quantity_textbox.TabIndex = 8;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(332, 391);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(367, 26);
            this.price_textbox.TabIndex = 9;
            // 
            // comment_textbox
            // 
            this.comment_textbox.Location = new System.Drawing.Point(332, 454);
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(367, 136);
            this.comment_textbox.TabIndex = 10;
            this.comment_textbox.Text = "";
            // 
            // unitofmeasurement_combobox
            // 
            this.unitofmeasurement_combobox.FormattingEnabled = true;
            this.unitofmeasurement_combobox.Items.AddRange(new object[] {
            "Piece",
            "Box",
            "Set",
            "Pair"});
            this.unitofmeasurement_combobox.Location = new System.Drawing.Point(332, 273);
            this.unitofmeasurement_combobox.Name = "unitofmeasurement_combobox";
            this.unitofmeasurement_combobox.Size = new System.Drawing.Size(367, 28);
            this.unitofmeasurement_combobox.TabIndex = 11;
            this.unitofmeasurement_combobox.SelectedIndexChanged += new System.EventHandler(this.unitofmeasurement_combobox_SelectedIndexChanged);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submit_button.Location = new System.Drawing.Point(155, 771);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(210, 105);
            this.submit_button.TabIndex = 12;
            this.submit_button.Text = "SUBMIT";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancel_button.Location = new System.Drawing.Point(559, 771);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(210, 105);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.unitofmeasurement_combobox);
            this.Controls.Add(this.comment_textbox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.item_name_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox item_name_textbox;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.RichTextBox comment_textbox;
        private System.Windows.Forms.ComboBox unitofmeasurement_combobox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
    }
}