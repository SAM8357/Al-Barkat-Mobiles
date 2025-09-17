namespace WindowsFormsApp4
{
    partial class update_mobile
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
            this.label6 = new System.Windows.Forms.Label();
            this.nameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.modalComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stockText = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceText = new Guna.UI2.WinForms.Guna2TextBox();
            this.concessionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.entryTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.updateButtton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.vendorText = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modal :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Come_Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sale_Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date/Time :";
            // 
            // nameComboBox
            // 
            this.nameComboBox.BackColor = System.Drawing.Color.Transparent;
            this.nameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.nameComboBox.ItemHeight = 30;
            this.nameComboBox.Location = new System.Drawing.Point(219, 27);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(200, 36);
            this.nameComboBox.TabIndex = 6;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // modalComboBox
            // 
            this.modalComboBox.BackColor = System.Drawing.Color.Transparent;
            this.modalComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modalComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modalComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modalComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modalComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.modalComboBox.ItemHeight = 30;
            this.modalComboBox.Location = new System.Drawing.Point(219, 74);
            this.modalComboBox.Name = "modalComboBox";
            this.modalComboBox.Size = new System.Drawing.Size(200, 36);
            this.modalComboBox.TabIndex = 7;
            this.modalComboBox.SelectedIndexChanged += new System.EventHandler(this.modalComboBox_SelectedIndexChanged);
            // 
            // stockText
            // 
            this.stockText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockText.DefaultText = "";
            this.stockText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stockText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stockText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stockText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stockText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stockText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stockText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stockText.Location = new System.Drawing.Point(219, 120);
            this.stockText.Name = "stockText";
            this.stockText.PlaceholderText = "";
            this.stockText.SelectedText = "";
            this.stockText.Size = new System.Drawing.Size(200, 36);
            this.stockText.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceText.DefaultText = "";
            this.priceText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceText.Location = new System.Drawing.Point(219, 168);
            this.priceText.Name = "priceText";
            this.priceText.PlaceholderText = "";
            this.priceText.SelectedText = "";
            this.priceText.Size = new System.Drawing.Size(200, 36);
            this.priceText.TabIndex = 9;
            this.priceText.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // concessionText
            // 
            this.concessionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.concessionText.DefaultText = "";
            this.concessionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.concessionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.concessionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.concessionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.concessionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.concessionText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.concessionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.concessionText.Location = new System.Drawing.Point(219, 214);
            this.concessionText.Name = "concessionText";
            this.concessionText.PlaceholderText = "";
            this.concessionText.SelectedText = "";
            this.concessionText.Size = new System.Drawing.Size(200, 36);
            this.concessionText.TabIndex = 10;
            // 
            // entryTimePicker
            // 
            this.entryTimePicker.Checked = true;
            this.entryTimePicker.FillColor = System.Drawing.Color.Red;
            this.entryTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.entryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.entryTimePicker.Location = new System.Drawing.Point(219, 314);
            this.entryTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.entryTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.entryTimePicker.Name = "entryTimePicker";
            this.entryTimePicker.Size = new System.Drawing.Size(200, 36);
            this.entryTimePicker.TabIndex = 11;
            this.entryTimePicker.Value = new System.DateTime(2025, 6, 16, 17, 32, 59, 882);
            // 
            // updateButtton
            // 
            this.updateButtton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButtton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButtton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButtton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButtton.FillColor = System.Drawing.Color.Red;
            this.updateButtton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButtton.ForeColor = System.Drawing.Color.White;
            this.updateButtton.Location = new System.Drawing.Point(547, 361);
            this.updateButtton.Name = "updateButtton";
            this.updateButtton.Size = new System.Drawing.Size(161, 42);
            this.updateButtton.TabIndex = 12;
            this.updateButtton.Text = "Update";
            this.updateButtton.Click += new System.EventHandler(this.updateButtton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vendor :";
            // 
            // vendorText
            // 
            this.vendorText.BackColor = System.Drawing.Color.Transparent;
            this.vendorText.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vendorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorText.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vendorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vendorText.ItemHeight = 30;
            this.vendorText.Location = new System.Drawing.Point(219, 262);
            this.vendorText.Name = "vendorText";
            this.vendorText.Size = new System.Drawing.Size(200, 36);
            this.vendorText.TabIndex = 14;
            this.vendorText.SelectedIndexChanged += new System.EventHandler(this.vendorText_SelectedIndexChanged);
            // 
            // update_mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vendorText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateButtton);
            this.Controls.Add(this.entryTimePicker);
            this.Controls.Add(this.concessionText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.modalComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update_mobile";
            this.Text = "update_mobile";
            this.Load += new System.EventHandler(this.update_mobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox nameComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox modalComboBox;
        private Guna.UI2.WinForms.Guna2TextBox stockText;
        private Guna.UI2.WinForms.Guna2TextBox priceText;
        private Guna.UI2.WinForms.Guna2TextBox concessionText;
        private Guna.UI2.WinForms.Guna2DateTimePicker entryTimePicker;
        private Guna.UI2.WinForms.Guna2Button updateButtton;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox vendorText;
    }
}