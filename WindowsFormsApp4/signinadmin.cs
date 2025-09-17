using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class signinadmin : Form
    {
        private Form preForm;
        public signinadmin()
        {
            InitializeComponent();
        }

        public signinadmin(Form preForm)
        {
            InitializeComponent();
            this.preForm = preForm;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       /* private void signinadmin_Load(object sender, EventArgs e)
        {
            lblProfileName.Text = DLsignin.LoggedInUserName;
            lblProfileName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;

        }*/
        private void lblProfileName_Click(object sender, EventArgs e)
        {
            
        }

        private void signinadmin_Load(object sender, EventArgs e)
        {
            lblProfileName.Text = DLsignin.LoggedInUserName;
            lblProfileName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            addmobile m = new addmobile();
            m.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            addcustomer a = new addcustomer();
            a.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            samsung s1 = new samsung();
            s1.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            iphone i = new iphone();
            i.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            nokia n = new nokia();
            n.Show();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            china china = new china();
            china.Show();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            used_mobile used_Mobile = new used_mobile();
            used_Mobile.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            preForm.Show();
            this.Close();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            displayused displayused = new displayused();
            displayused.Show();
        }

        
        
    }
}
