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
    public partial class updatecustomerrrr : Form
    {
        string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private long customerId;
        private int selectedPurchaseId = -1;
        public updatecustomerrrr(long id)
        {
            InitializeComponent();
            this.customerId = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatecustomerrrr_Load(object sender, EventArgs e)
        {
            id_txt.Text = customerId.ToString();
            id_txt.ReadOnly = true;
            LoadCustomerAndPurchases();

        }

        private void LoadCustomerAndPurchases()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load Customer name
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Customer WHERE ID_No = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", customerId);
                object nameObj = cmd.ExecuteScalar();

                if (nameObj != null)
                {
                    name_txt.Text = nameObj.ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    this.Close();
                    return;
                }

                // Load Purchases
                string purchaseQuery = "SELECT CP.PurchaseID, CP.Mobile, CP.Mobile_Model, CP.Amount, CP.D_Amount FROM Customer_Purchase CP JOIN Customer C ON C.CustomerID = CP.CustomerID WHERE C.ID_No = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(purchaseQuery, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", customerId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
        }



        private void FillTextBoxes(DataRow row)
        {
            name_txt.Text = row["Name"].ToString();
            mobile_txt.Text = row["Mobile"].ToString();
            modal_txt.Text = row["Mobile_Model"].ToString();
            price_txt.Text = row["Amount"].ToString();
            quantity_txt.Text = row["D_Amount"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedPurchaseId == -1)
            {
                MessageBox.Show("Please select a purchase to update.");
                return;
            }

            if (!decimal.TryParse(price_txt.Text.Trim(), out decimal amount) || !int.TryParse(quantity_txt.Text.Trim(), out int qty))
            {
                MessageBox.Show("Invalid price or quantity.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE Customer_Purchase 
                                 SET Mobile = @Mobile, Mobile_Model = @Model, Amount = @Amount, D_Amount = @Qty 
                                 WHERE PurchaseID = @PurchaseID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Mobile", mobile_txt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Model", modal_txt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Qty", qty);
                    cmd.Parameters.AddWithValue("@PurchaseID", selectedPurchaseId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Purchase updated successfully.");
                        LoadCustomerAndPurchases();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        

        private void mobile_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                selectedPurchaseId = Convert.ToInt32(row.Cells["PurchaseID"].Value);
                mobile_txt.Text = row.Cells["Mobile"].Value.ToString();
                modal_txt.Text = row.Cells["Mobile_Model"].Value.ToString();
                price_txt.Text = row.Cells["Amount"].Value.ToString();
                quantity_txt.Text = row.Cells["D_Amount"].Value.ToString();
            }
        }
    }

}
