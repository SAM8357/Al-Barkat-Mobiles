namespace WindowsFormsApp4
{
    partial class customerr_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerr_show));
            this.namelabel = new System.Windows.Forms.Label();
            this.mobilelabel = new System.Windows.Forms.Label();
            this.modallabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.discountlabel = new System.Windows.Forms.Label();
            this.idno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.mobilelabel.BackColor = System.Drawing.Color.Transparent;
            this.modallabel.BackColor = System.Drawing.Color.Transparent;
            this.amountlabel.BackColor = System.Drawing.Color.Transparent;
            this.discountlabel.BackColor = System.Drawing.Color.Transparent;
            this.idno.BackColor = System.Drawing.Color.Transparent;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(330, 357);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 30);
            this.namelabel.TabIndex = 0;
            // 
            // mobilelabel
            // 
            this.mobilelabel.AutoSize = true;
            this.mobilelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelabel.Location = new System.Drawing.Point(330, 397);
            this.mobilelabel.Name = "mobilelabel";
            this.mobilelabel.Size = new System.Drawing.Size(0, 30);
            this.mobilelabel.TabIndex = 1;
            // 
            // modallabel
            // 
            this.modallabel.AutoSize = true;
            this.modallabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modallabel.Location = new System.Drawing.Point(330, 437);
            this.modallabel.Name = "modallabel";
            this.modallabel.Size = new System.Drawing.Size(0, 30);
            this.modallabel.TabIndex = 2;
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(330, 477);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(0, 30);
            this.amountlabel.TabIndex = 3;
            // 
            // discountlabel
            // 
            this.discountlabel.AutoSize = true;
            this.discountlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlabel.Location = new System.Drawing.Point(330, 517);
            this.discountlabel.Name = "discountlabel";
            this.discountlabel.Size = new System.Drawing.Size(0, 30);
            this.discountlabel.TabIndex = 4;
            // 
            // idno
            // 
            this.idno.AutoSize = true;
            this.idno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idno.Location = new System.Drawing.Point(330, 557);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(0, 30);
            this.idno.TabIndex = 5;
            // 
            // customerr_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 749);
            this.Controls.Add(this.idno);
            this.Controls.Add(this.discountlabel);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.modallabel);
            this.Controls.Add(this.mobilelabel);
            this.Controls.Add(this.namelabel);
            this.Name = "customerr_show";
            this.Text = "customerr_show";
            this.Load += new System.EventHandler(this.customerr_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label mobilelabel;
        private System.Windows.Forms.Label modallabel;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label discountlabel;
        private System.Windows.Forms.Label idno;
    }
}