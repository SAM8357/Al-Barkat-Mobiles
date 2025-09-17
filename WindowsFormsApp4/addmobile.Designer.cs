namespace WindowsFormsApp4
{
    partial class addmobile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_text = new Guna.UI2.WinForms.Guna2ComboBox();
            this.modal_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.stock_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.price_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.concession_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_button = new Guna.UI2.WinForms.Guna2Button();
            this.Delete_Button = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vendor_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.entryTimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.invoicebtn = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.vendorNumber_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 39);
            this.label1.MinimumSize = new System.Drawing.Size(70, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 85);
            this.label2.MinimumSize = new System.Drawing.Size(70, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Come_Price :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sale_Price :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.Transparent;
            this.name_text.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.name_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_text.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_text.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.name_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.name_text.ItemHeight = 30;
            this.name_text.Items.AddRange(new object[] {
            "SAMSUNG",
            "IPHONE",
            "VIVO",
            "OPPO",
            "INFINIX",
            "TECHNO",
            "NOKIA"});
            this.name_text.Location = new System.Drawing.Point(239, 39);
            this.name_text.MinimumSize = new System.Drawing.Size(200, 0);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(200, 36);
            this.name_text.TabIndex = 5;
            this.name_text.Tag = "New_Mobile";
            // 
            // modal_text
            // 
            this.modal_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modal_text.DefaultText = "";
            this.modal_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.modal_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.modal_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modal_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modal_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modal_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modal_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modal_text.Location = new System.Drawing.Point(239, 85);
            this.modal_text.Name = "modal_text";
            this.modal_text.PlaceholderText = "";
            this.modal_text.SelectedText = "";
            this.modal_text.Size = new System.Drawing.Size(200, 36);
            this.modal_text.TabIndex = 6;
            // 
            // stock_text
            // 
            this.stock_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_text.DefaultText = "";
            this.stock_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stock_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stock_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stock_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_text.Location = new System.Drawing.Point(239, 131);
            this.stock_text.Name = "stock_text";
            this.stock_text.PlaceholderText = "";
            this.stock_text.SelectedText = "";
            this.stock_text.Size = new System.Drawing.Size(200, 36);
            this.stock_text.TabIndex = 7;
            // 
            // price_text
            // 
            this.price_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_text.DefaultText = "";
            this.price_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_text.Location = new System.Drawing.Point(239, 180);
            this.price_text.Name = "price_text";
            this.price_text.PlaceholderText = "";
            this.price_text.SelectedText = "";
            this.price_text.Size = new System.Drawing.Size(200, 36);
            this.price_text.TabIndex = 8;
            // 
            // concession_text
            // 
            this.concession_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.concession_text.DefaultText = "";
            this.concession_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.concession_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.concession_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.concession_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.concession_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.concession_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.concession_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.concession_text.Location = new System.Drawing.Point(239, 226);
            this.concession_text.Name = "concession_text";
            this.concession_text.PlaceholderText = "";
            this.concession_text.SelectedText = "";
            this.concession_text.Size = new System.Drawing.Size(200, 36);
            this.concession_text.TabIndex = 9;
            // 
            // add_button
            // 
            this.add_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_button.FillColor = System.Drawing.Color.Red;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.DimGray;
            this.add_button.HoverState.FillColor = System.Drawing.Color.Black;
            this.add_button.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.add_button.Location = new System.Drawing.Point(282, 411);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(106, 35);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Add";
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_Button.FillColor = System.Drawing.Color.Red;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.DimGray;
            this.Delete_Button.Location = new System.Drawing.Point(282, 464);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(106, 35);
            this.Delete_Button.TabIndex = 11;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vendor :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // vendor_txt
            // 
            this.vendor_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendor_txt.DefaultText = "";
            this.vendor_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vendor_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vendor_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vendor_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vendor_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendor_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendor_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendor_txt.Location = new System.Drawing.Point(239, 268);
            this.vendor_txt.Name = "vendor_txt";
            this.vendor_txt.PlaceholderText = "";
            this.vendor_txt.SelectedText = "";
            this.vendor_txt.Size = new System.Drawing.Size(200, 36);
            this.vendor_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date/Time :";
            // 
            // entryTimepicker
            // 
            this.entryTimepicker.BackColor = System.Drawing.Color.Red;
            this.entryTimepicker.Checked = true;
            this.entryTimepicker.FillColor = System.Drawing.Color.Red;
            this.entryTimepicker.FocusedColor = System.Drawing.Color.Red;
            this.entryTimepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entryTimepicker.ForeColor = System.Drawing.Color.Black;
            this.entryTimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.entryTimepicker.Location = new System.Drawing.Point(239, 359);
            this.entryTimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryTimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryTimepicker.Name = "entryTimepicker";
            this.entryTimepicker.Size = new System.Drawing.Size(200, 36);
            this.entryTimepicker.TabIndex = 15;
            this.entryTimepicker.Value = new System.DateTime(2025, 6, 16, 13, 1, 54, 578);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Location = new System.Drawing.Point(118, 464);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(106, 35);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Update";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // invoicebtn
            // 
            this.invoicebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoicebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoicebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoicebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoicebtn.FillColor = System.Drawing.Color.Red;
            this.invoicebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicebtn.ForeColor = System.Drawing.Color.DimGray;
            this.invoicebtn.Location = new System.Drawing.Point(463, 464);
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Size = new System.Drawing.Size(106, 35);
            this.invoicebtn.TabIndex = 17;
            this.invoicebtn.Text = "Invoice";
            this.invoicebtn.Click += new System.EventHandler(this.invoicebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vendor\'s No :";
            // 
            // vendorNumber_txt
            // 
            this.vendorNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vendorNumber_txt.DefaultText = "";
            this.vendorNumber_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vendorNumber_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vendorNumber_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vendorNumber_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vendorNumber_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorNumber_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vendorNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorNumber_txt.Location = new System.Drawing.Point(239, 308);
            this.vendorNumber_txt.Name = "vendorNumber_txt";
            this.vendorNumber_txt.PlaceholderText = "";
            this.vendorNumber_txt.SelectedText = "";
            this.vendorNumber_txt.Size = new System.Drawing.Size(200, 36);
            this.vendorNumber_txt.TabIndex = 19;
            // 
            // addmobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.vendorNumber_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.invoicebtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.entryTimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vendor_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.concession_text);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.stock_text);
            this.Controls.Add(this.modal_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addmobile";
            this.Text = "addmobile";
            this.Load += new System.EventHandler(this.addmobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox name_text;
        private Guna.UI2.WinForms.Guna2TextBox modal_text;
        private Guna.UI2.WinForms.Guna2TextBox stock_text;
        private Guna.UI2.WinForms.Guna2TextBox price_text;
        private Guna.UI2.WinForms.Guna2TextBox concession_text;
        private Guna.UI2.WinForms.Guna2Button add_button;
        private Guna.UI2.WinForms.Guna2Button Delete_Button;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox vendor_txt;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryTimepicker;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button invoicebtn;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox vendorNumber_txt;
    }
}