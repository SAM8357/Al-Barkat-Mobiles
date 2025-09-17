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

    public partial class update_used : Form
    {
        string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        public update_used()
        {
            InitializeComponent();
        }

        private void update_used_Load(object sender, EventArgs e)
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



        private void update_Click(object sender, EventArgs e)
        {
            string selectedName = name_combo.SelectedItem?.ToString();
            string selectedModel = model_combo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedName) || string.IsNullOrEmpty(selectedModel))
            {
                MessageBox.Show("Please select both Name and Model.");
                return;
            }

            update2_used update2Form = new update2_used(selectedName, selectedModel);
            update2Form.Show();
           
        }

        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}

