namespace WindowsFormsApp4
{
    partial class customer_show
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
            this.namelabel = new System.Windows.Forms.Label();
            this.mobilelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(279, 74);
            this.namelabel.MinimumSize = new System.Drawing.Size(180, 36);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(180, 36);
            this.namelabel.TabIndex = 0;
            // 
            // mobilelabel
            // 
            this.mobilelabel.AutoSize = true;
            this.mobilelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelabel.Location = new System.Drawing.Point(281, 120);
            this.mobilelabel.Name = "mobilelabel";
            this.mobilelabel.Size = new System.Drawing.Size(0, 30);
            this.mobilelabel.TabIndex = 1;
            // 
            // customer_show
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mobilelabel);
            this.Controls.Add(this.namelabel);
            this.Enabled = false;
            this.Name = "customer_show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label mobilelabel;
    }
}