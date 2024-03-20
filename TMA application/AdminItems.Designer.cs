namespace TMA_application
{
    partial class AdminItems
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.measure = new System.Windows.Forms.ComboBox();
            this.group = new System.Windows.Forms.ComboBox();
            this.contact = new System.Windows.Forms.Label();
            this.storage = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.measurement = new System.Windows.Forms.Label();
            this.item_group = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.id_text = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.database1DataSet = new TMA_application.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1572, 120);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(498, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEMS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.measure);
            this.panel2.Controls.Add(this.group);
            this.panel2.Controls.Add(this.contact);
            this.panel2.Controls.Add(this.storage);
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.quantity);
            this.panel2.Controls.Add(this.measurement);
            this.panel2.Controls.Add(this.item_group);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(2, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 577);
            this.panel2.TabIndex = 3;
            // 
            // measure
            // 
            this.measure.FormattingEnabled = true;
            this.measure.Items.AddRange(new object[] {
            "piece",
            "box",
            "set",
            "pair"});
            this.measure.Location = new System.Drawing.Point(121, 138);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(197, 28);
            this.measure.TabIndex = 18;
            // 
            // group
            // 
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "Electronics",
            "Clothing",
            "Furniture",
            "Appliances"});
            this.group.Location = new System.Drawing.Point(121, 83);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(197, 28);
            this.group.TabIndex = 17;
            this.group.SelectedIndexChanged += new System.EventHandler(this.group_SelectedIndexChanged);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(117, 352);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(115, 20);
            this.contact.TabIndex = 16;
            this.contact.Text = "contact person";
            // 
            // storage
            // 
            this.storage.AutoSize = true;
            this.storage.Location = new System.Drawing.Point(117, 293);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(122, 20);
            this.storage.TabIndex = 15;
            this.storage.Text = "storage location";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Bisque;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Location = new System.Drawing.Point(93, 431);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(270, 99);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(117, 233);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(133, 20);
            this.price.TabIndex = 14;
            this.price.Text = "price without VAT";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(117, 173);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(65, 20);
            this.quantity.TabIndex = 13;
            this.quantity.Text = "quantity";
            // 
            // measurement
            // 
            this.measurement.AutoSize = true;
            this.measurement.Location = new System.Drawing.Point(117, 115);
            this.measurement.Name = "measurement";
            this.measurement.Size = new System.Drawing.Size(155, 20);
            this.measurement.TabIndex = 12;
            this.measurement.Text = "unit of measurement";
            // 
            // item_group
            // 
            this.item_group.AutoSize = true;
            this.item_group.Location = new System.Drawing.Point(117, 59);
            this.item_group.Name = "item_group";
            this.item_group.Size = new System.Drawing.Size(84, 20);
            this.item_group.TabIndex = 11;
            this.item_group.Text = "item group";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(121, 375);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 26);
            this.textBox6.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 316);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 26);
            this.textBox5.TabIndex = 9;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Bisque;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_button.Location = new System.Drawing.Point(462, 780);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(324, 99);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Bisque;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update_button.Location = new System.Drawing.Point(81, 780);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(305, 99);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToOrderColumns = true;
            this.datagrid.AutoGenerateColumns = false;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.DataSource = this.database1DataSetBindingSource;
            this.datagrid.Location = new System.Drawing.Point(472, 120);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersWidth = 62;
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(1102, 577);
            this.datagrid.TabIndex = 4;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(95, 732);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(139, 26);
            this.id_text.TabIndex = 5;
            this.id_text.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(91, 709);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(146, 20);
            this.id.TabIndex = 6;
            this.id.Text = "id for delete/update";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // AdminItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1571, 944);
            this.Controls.Add(this.id);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminItems";
            this.Text = "AdminItems";
            this.Load += new System.EventHandler(this.AdminItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label item_group;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label storage;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label measurement;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.ComboBox measure;
        private System.Windows.Forms.ComboBox group;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
    }
}