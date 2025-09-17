namespace WindowsFormsApp4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.eyeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(111, 38);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.Transparent;
            this.username.BorderRadius = 6;
            this.username.BorderThickness = 0;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.Black;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.username.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.username.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.username.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.username.IconLeft = ((System.Drawing.Image)(resources.GetObject("username.IconLeft")));
            this.username.Location = new System.Drawing.Point(59, 135);
            this.username.Name = "username";
            this.username.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.username.PlaceholderText = "username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(169, 28);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.Transparent;
            this.password.BorderRadius = 6;
            this.password.BorderThickness = 0;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.Black;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.password.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.password.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.password.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.password.IconLeft = ((System.Drawing.Image)(resources.GetObject("password.IconLeft")));
            this.password.Location = new System.Drawing.Point(59, 169);
            this.password.Name = "password";
            this.password.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.password.PlaceholderText = "password";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(169, 28);
            this.password.TabIndex = 3;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 6;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2GradientButton1.Location = new System.Drawing.Point(59, 284);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2GradientButton1.Size = new System.Drawing.Size(169, 28);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "Create";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.AllowDrop = true;
            this.ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.ComboBox.BorderRadius = 6;
            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FillColor = System.Drawing.Color.Black;
            this.ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.ComboBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.ComboBox.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.ComboBox.HoverState.ForeColor = System.Drawing.Color.DimGray;
            this.ComboBox.ItemHeight = 30;
            this.ComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ComboBox.ItemsAppearance.BackColor = System.Drawing.Color.Black;
            this.ComboBox.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Maroon;
            this.ComboBox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Black;
            this.ComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Maroon;
            this.ComboBox.Location = new System.Drawing.Point(59, 242);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(169, 36);
            this.ComboBox.TabIndex = 5;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1, 1);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(29, 28);
            this.guna2ImageButton1.TabIndex = 6;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // eyeButton
            // 
            this.eyeButton.BackColor = System.Drawing.Color.Black;
            this.eyeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.eyeButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.eyeButton.Image = ((System.Drawing.Image)(resources.GetObject("eyeButton.Image")));
            this.eyeButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.eyeButton.ImageRotate = 0F;
            this.eyeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.eyeButton.Location = new System.Drawing.Point(190, 203);
            this.eyeButton.Name = "eyeButton";
            this.eyeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.eyeButton.ShadowDecoration.BorderRadius = 12;
            this.eyeButton.Size = new System.Drawing.Size(28, 23);
            this.eyeButton.TabIndex = 7;
            this.eyeButton.Click += new System.EventHandler(this.eyeButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 324);
            this.Controls.Add(this.eyeButton);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton eyeButton;
    }
}