using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Web.SessionState;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        string connection_string = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;";
        private Form previousForm;
        private bool passwordVisible = false;
        public Form2(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            signpass.PasswordChar = '●';
            passwordVisible = false;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string users = signuser.Text.Trim();
            string pass = signpass.Text.Trim();
            string role = guna2ComboBox1.SelectedItem.ToString().Trim();

            if (users == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();

                if (role == "admin")
                {
                    string query = "SELECT users, pass FROM [Users] WHERE users = @users AND pass = @pass";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@users", users);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string userName = reader["users"].ToString();
                        DLsignin.LoggedInUserName = userName;
                        DLsignin.UserPass = pass;

                        reader.Close();

                        signinadmin si = new signinadmin(this);
                        si.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin credentials!");
                    }
                }
                else if (role.ToLower() == "customer")  // safer comparison
                {
                    if (!int.TryParse(pass, out int idNo))
                    {
                        MessageBox.Show("Customer ID must be a number.");
                        return;
                    }

                    string custQuery = "SELECT * FROM add_customer WHERE Name = @users AND ID_No = @id";
                    SqlCommand custCmd = new SqlCommand(custQuery, conn);
                    custCmd.Parameters.AddWithValue("@users", users);
                    custCmd.Parameters.AddWithValue("@id", idNo);  // use integer

                    SqlDataReader custReader = custCmd.ExecuteReader();

                    if (custReader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(custReader);

                        customerr_show custForm = new customerr_show(dt.Rows[0]);
                        custForm.Show();
                        this.Hide();  // also hide the login form
                    }
                    else
                    {
                        MessageBox.Show("Customer not found or ID incorrect.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                signuser.Text = "";
                signpass.Text = "";
                guna2ComboBox1.SelectedIndex = -1;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            previousForm.Show(); 
            this.Close();
        }

        private void eyeButton_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                signpass.PasswordChar = '●'; // Mask
                passwordVisible = false;

                // Optional: change to closed eye image
                // eyeButton.Image = Properties.Resources.eye_closed;
            }
            else
            {
                signpass.PasswordChar = '\0'; // Show
                passwordVisible = true;

                // Optional: change to open eye image
                // eyeButton.Image = Properties.Resources.eye_open;
            }
        }
    }
}
