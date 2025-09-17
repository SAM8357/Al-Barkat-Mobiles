namespace WindowsFormsApp4
{
    partial class delete_used
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
            this.name_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.model_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modal :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name_combo
            // 
            this.name_combo.BackColor = System.Drawing.Color.Transparent;
            this.name_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.name_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.name_combo.ItemHeight = 30;
            this.name_combo.Items.AddRange(new object[] {
            "SAMSUNG",
            "IPHONE",
            "NOKIA",
            "OPPO",
            "VIVO",
            "TECHNO",
            "INFINIX"});
            this.name_combo.Location = new System.Drawing.Point(361, 35);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(218, 36);
            this.name_combo.TabIndex = 2;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.name_combo_SelectedIndexChanged_1);
            // 
            // model_combo
            // 
            this.model_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.model_combo.BackColor = System.Drawing.Color.Transparent;
            this.model_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.model_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.model_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.model_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.model_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.model_combo.ItemHeight = 30;
            this.model_combo.Location = new System.Drawing.Point(362, 79);
            this.model_combo.Name = "model_combo";
            this.model_combo.Size = new System.Drawing.Size(217, 36);
            this.model_combo.TabIndex = 3;
            this.model_combo.SelectedIndexChanged += new System.EventHandler(this.model_combo_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Location = new System.Drawing.Point(623, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(150, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Delete";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // delete_used
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.model_combo);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "delete_used";
            this.Text = "delete_used";
            this.Load += new System.EventHandler(this.delete_used_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox name_combo;
        private Guna.UI2.WinForms.Guna2ComboBox model_combo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}