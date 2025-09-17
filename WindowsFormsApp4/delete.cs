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
using Guna.UI2.WinForms;

namespace WindowsFormsApp4
{
    public partial class delete : Form
    {
        private string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";



        public delete()
        {
            InitializeComponent();
        }

       

        private void delete_Load_1(object sender, EventArgs e)
        {
            LoadCustomerData();
            LoadCustomerGrid();
        }

        private void LoadCustomerData()
        {
            cmbCustomerCNIC.Items.Clear();
            cmbCustomerName.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_No, Name FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCustomerCNIC.Items.Add(reader["ID_No"].ToString());
                        cmbCustomerName.Items.Add(reader["Name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message);
                }
            }
        }

        private void LoadCustomerGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    customerGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer table: " + ex.Message);
                }
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cmbCustomerCNIC.SelectedItem == null && cmbCustomerName.SelectedItem == null)
            {
                MessageBox.Show("Please select either a Customer ID or Name.");
                return;
            }

            string selectedId = cmbCustomerCNIC.SelectedItem?.ToString();
            string selectedName = cmbCustomerName.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Customer WHERE 1 = 1";

                    if (!string.IsNullOrEmpty(selectedId))
                        query += " AND ID_No = @ID_No";
                    if (!string.IsNullOrEmpty(selectedName))
                        query += " AND Name = @Name";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(selectedId))
                        cmd.Parameters.AddWithValue("@ID_No", selectedId);
                    if (!string.IsNullOrEmpty(selectedName))
                        cmd.Parameters.AddWithValue("@Name", selectedName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    customerGridView.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
        }

        private void cmbCustomerCNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCnic = cmbCustomerCNIC.SelectedItem?.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Customer WHERE ID_No = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedCnic);

                try
                {
                    conn.Open();
                    object name = cmd.ExecuteScalar();
                    if (name != null)
                    {
                        cmbCustomerName.SelectedItem = name.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error syncing name: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCustomerCNIC.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer CNIC to delete.");
                return;
            }

            string selectedCnic = cmbCustomerCNIC.SelectedItem.ToString();

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Customer WHERE ID_No = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedCnic);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully.");
                        LoadCustomerData();
                        LoadCustomerGrid();
                        cmbCustomerCNIC.SelectedIndex = -1;
                        cmbCustomerName.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Customer not found or already deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

