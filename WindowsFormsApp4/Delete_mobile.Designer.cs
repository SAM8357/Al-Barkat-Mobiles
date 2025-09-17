namespace WindowsFormsApp4
{
    partial class Delete_mobile
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
            this.nameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.modelComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBackup = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modal :";
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
            this.nameComboBox.Location = new System.Drawing.Point(234, 39);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(212, 36);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.modelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modelComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modelComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.modelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.modelComboBox.ItemHeight = 30;
            this.modelComboBox.Location = new System.Drawing.Point(234, 81);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(212, 36);
            this.modelComboBox.TabIndex = 3;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.DimGray;
            this.deleteButton.Location = new System.Drawing.Point(549, 204);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 35);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendor :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.vendorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.vendorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vendorComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vendorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.vendorComboBox.ItemHeight = 30;
            this.vendorComboBox.Location = new System.Drawing.Point(234, 130);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(212, 36);
            this.vendorComboBox.TabIndex = 6;
            // 
            // btnBackup
            // 
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.FillColor = System.Drawing.Color.Red;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.DimGray;
            this.btnBackup.Location = new System.Drawing.Point(455, 245);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(118, 36);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDeleteBackup
            // 
            this.btnDeleteBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBackup.FillColor = System.Drawing.Color.Red;
            this.btnDeleteBackup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBackup.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteBackup.Location = new System.Drawing.Point(636, 245);
            this.btnDeleteBackup.Name = "btnDeleteBackup";
            this.btnDeleteBackup.Size = new System.Drawing.Size(122, 36);
            this.btnDeleteBackup.TabIndex = 9;
            this.btnDeleteBackup.Text = "DL_BAK";
            this.btnDeleteBackup.Click += new System.EventHandler(this.btnDeleteBackup_Click);
            // 
            // Delete_mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteBackup);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.vendorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete_mobile";
            this.Text = "Delete_mobile";
            this.Load += new System.EventHandler(this.Delete_mobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox nameComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox modelComboBox;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox vendorComboBox;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBackup;
    }
}