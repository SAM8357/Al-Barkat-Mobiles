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
    public partial class delete_used : Form
    {
        string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public delete_used()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void delete_used_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Name FROM used_mobile";

                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        name_combo.Items.Add(reader["Name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading names: " + ex.Message);
                }
            }
        }
        
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = name_combo.SelectedItem?.ToString();
            string model = model_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Please select both Name and Model to delete.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this mobile?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM used_mobile WHERE Name = @Name AND Model = @Model";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Model", model);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Mobile deleted successfully.");
                        model_combo.Items.Clear(); 
                    }
                    else
                    {
                        MessageBox.Show("No matching mobile found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void name_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            model_combo.Items.Clear();
            model_combo.Text = "";

            string selectedName = name_combo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName))
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Model FROM used_mobile WHERE Name = @Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", selectedName);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        model_combo.Items.Add(reader["Model"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading models: " + ex.Message);
                }
            }
        }

        private void model_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
