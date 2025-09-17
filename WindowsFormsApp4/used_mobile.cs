using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class used_mobile : Form
    {
        public used_mobile()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string query = "INSERT INTO used_mobile (Name, Model, Stock, Price, Concession) " +
                           "VALUES (@Name, @Model, @Stock, @Price, @Concession)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@Name", name_txt.Text);
                cmd.Parameters.AddWithValue("@Model", modal_txt.Text);
                cmd.Parameters.AddWithValue("@Stock", int.Parse(stock_txt.Text));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(price_txt.Text));
                cmd.Parameters.AddWithValue("@Concession", decimal.Parse(concession_txt.Text));

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mobile added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No data inserted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void used_mobile_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            delete_used delete = new delete_used();
            delete.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            update_used update = new update_used();
            update.Show();
        }
    }
    }

