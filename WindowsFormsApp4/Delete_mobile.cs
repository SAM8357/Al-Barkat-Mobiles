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
    public partial class Delete_mobile : Form
    {
        string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public Delete_mobile()
        {
            InitializeComponent();
        }

        private void Delete_mobile_Load(object sender, EventArgs e)
        {
            LoadMobileNames();
            btnBackup.Click += new EventHandler(btnBackup_Click);
            btnDeleteBackup.Click += new EventHandler(btnDeleteBackup_Click);
        }

        private void LoadMobileNames()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Name FROM ADD_MOBILE";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    nameComboBox.Items.Clear();
                    while (reader.Read())
                    {
                        nameComboBox.Items.Add(reader["Name"].ToString());
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string selectedName = nameComboBox.SelectedItem?.ToString();
            string selectedModel = modelComboBox.SelectedItem?.ToString();
            string selectedVendor = vendorComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedName) || string.IsNullOrEmpty(selectedModel) || string.IsNullOrEmpty(selectedVendor))
            {
                MessageBox.Show("Please select Name, Model, and Vendor.");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedName} - {selectedModel} from {selectedVendor}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Get the record to backup
                    string selectQuery = "SELECT * FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model AND Vendor = @Vendor";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@Name", selectedName);
                    selectCmd.Parameters.AddWithValue("@Model", selectedModel);
                    selectCmd.Parameters.AddWithValue("@Vendor", selectedVendor);

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader); // Load result into a DataTable to use after closing the reader

                    if (dt.Rows.Count > 0)
                    {
                        // Step 2: Backup into Deleted_Mobiles_Backup
                        DataRow row = dt.Rows[0];

                        string backupQuery = @"INSERT INTO Deleted_Mobiles_Backup 
                                        (Name, Model, Stock, Price, Concession, Vendor, VendorNumber, EntryTime)
                                        VALUES (@Name, @Model, @Stock, @Price, @Concession, @Vendor, @VendorNumber, @EntryTime)";
                        SqlCommand backupCmd = new SqlCommand(backupQuery, conn);
                        backupCmd.Parameters.AddWithValue("@Name", row["Name"]);
                        backupCmd.Parameters.AddWithValue("@Model", row["Model"]);
                        backupCmd.Parameters.AddWithValue("@Stock", row["Stock"]);
                        backupCmd.Parameters.AddWithValue("@Price", row["Price"]);
                        backupCmd.Parameters.AddWithValue("@Concession", row["Concession"]);
                        backupCmd.Parameters.AddWithValue("@Vendor", row["Vendor"]);
                        backupCmd.Parameters.AddWithValue("@VendorNumber", row["VendorNumber"]);
                        backupCmd.Parameters.AddWithValue("@EntryTime", row["EntryTime"]);

                        backupCmd.ExecuteNonQuery();

                        // Step 3: Delete the record from ADD_MOBILE
                        string deleteQuery = "DELETE FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model AND Vendor = @Vendor";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@Name", selectedName);
                        deleteCmd.Parameters.AddWithValue("@Model", selectedModel);
                        deleteCmd.Parameters.AddWithValue("@Vendor", selectedVendor);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mobile deleted and backed up successfully.");
                            vendorComboBox.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed after backup.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found for backup.");
                    }
                }
            }
        }

        



        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();
            vendorComboBox.Items.Clear();

            string selectedName = nameComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedName))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Model FROM ADD_MOBILE WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", selectedName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                modelComboBox.Items.Add(reader["Model"].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorComboBox.Items.Clear();

            string selectedName = nameComboBox.SelectedItem?.ToString();
            string selectedModel = modelComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedName) && !string.IsNullOrEmpty(selectedModel))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Vendor FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", selectedName);
                        cmd.Parameters.AddWithValue("@Model", selectedModel);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vendorComboBox.Items.Add(reader["Vendor"].ToString());
                            }
                        }
                    }
                }
            }

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string selectedName = nameComboBox.SelectedItem?.ToString();
            string selectedModel = modelComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedName) || string.IsNullOrEmpty(selectedModel))
            {
                MessageBox.Show("Please select both Name and Model.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Deleted_Mobiles_Backup WHERE Name = @Name AND Model = @Model";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", selectedName);
                    cmd.Parameters.AddWithValue("@Model", selectedModel);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine($"Backup entries for {selectedName} - {selectedModel}:");
                            sb.AppendLine("---------------------------------------------------");
                            while (reader.Read())
                            {
                                sb.AppendLine($"Vendor: {reader["Vendor"]} | Price: {reader["Price"]} | Stock: {reader["Stock"]}");
                            }
                            MessageBox.Show(sb.ToString(), "Backup Info");
                        }
                        else
                        {
                            MessageBox.Show("No backup found for the selected mobile.");
                        }
                    }
                }
            }
        }

        private void btnDeleteBackup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete ALL backup data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM Deleted_Mobiles_Backup";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} backup record(s) deleted.");
                    }
                }
            }
        }
    }
}
