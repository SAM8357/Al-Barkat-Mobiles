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
    public partial class update_mobile : Form
    {
        private string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public update_mobile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_mobile_Load(object sender, EventArgs e)
        {
            LoadMobileNames();
        }

        private void LoadMobileNames()
        {
            nameComboBox.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT DISTINCT Name FROM ADD_MOBILE";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameComboBox.Items.Add(reader["Name"].ToString());
                    }
                }
            }
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modalComboBox.Items.Clear();
            string selectedName = nameComboBox.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Model FROM ADD_MOBILE WHERE Name = @Name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", selectedName);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        modalComboBox.Items.Add(reader["Model"].ToString());
                    }
                }
            }
        }

        private void modalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = nameComboBox.SelectedItem?.ToString();
            string model = modalComboBox.SelectedItem?.ToString();

            vendorText.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Vendor FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Model", model);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        vendorText.Items.Add(reader["Vendor"].ToString());
                    }
                }
            }

        }


        

        private void updateButtton_Click(object sender, EventArgs e)
        {
            string name = nameComboBox.SelectedItem?.ToString();
            string model = modalComboBox.SelectedItem?.ToString();
            string vendor = vendorText.SelectedItem?.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE ADD_MOBILE SET Stock = @Stock, Price = @Price, Concession = @Concession, EntryTime = @EntryTime " +
                "WHERE Name = @Name AND Model = @Model AND Vendor = @Vendor";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(stockText.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceText.Text));
                    cmd.Parameters.AddWithValue("@Concession", decimal.Parse(concessionText.Text));
                    cmd.Parameters.AddWithValue("@Vendor", vendor);
                    cmd.Parameters.AddWithValue("@EntryTime", entryTimePicker.Value);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Model", model);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Mobile details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Update failed. Mobile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vendorText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = nameComboBox.SelectedItem?.ToString();
            string model = modalComboBox.SelectedItem?.ToString();
            string vendor = vendorText.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model AND Vendor = @Vendor";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Vendor", vendor);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        stockText.Text = reader["Stock"].ToString();
                        priceText.Text = reader["Price"].ToString();
                        concessionText.Text = reader["Concession"].ToString();

                        if (reader["EntryTime"] != DBNull.Value)
                        {
                            entryTimePicker.Value = Convert.ToDateTime(reader["EntryTime"]);
                        }
                        else
                        {
                            entryTimePicker.Value = DateTime.Now;
                        }
                    }
                }
            }
        }
    }
}

