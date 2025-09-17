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

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        string connection_string = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;";
        private Form previous;
        private bool passwordVisible = false;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string users = username.Text.Trim();
            string pass = password.Text.Trim();
            string roles = ComboBox.Text.Trim();
           if (users =="" || pass == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            SqlConnection conn = new SqlConnection(connection_string);
            if (roles == "Admin")
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users(users,pass)VALUES(@users,@pass)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@users", users);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Successfully entered.");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }

                }
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.username.HoverState.PlaceholderForeColor = Color.DimGray;
            password.PasswordChar = '●';
            passwordVisible = false;

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }

        private void eyeButton_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                password.PasswordChar = '●';
                passwordVisible = false;
                
            }
            else
            {
                password.PasswordChar = '\0';
                passwordVisible = true;
               
            }
        }
    }
}
