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
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class addmobile : Form
    {
        public addmobile()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addmobile_Load(object sender, EventArgs e)
        {
            invoicebtn.Click += new EventHandler(invoicebtn_Click);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM ADD_MOBILE WHERE Name = @Name AND Model = @Model";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Name", name_text.Text);
                    checkCmd.Parameters.AddWithValue("@Model", modal_text.Text);

                    // If needed, check result here with ExecuteScalar()

                    string insertQuery = "INSERT INTO ADD_MOBILE (Name, Model, Stock, Price, Concession, Vendor, VendorNumber, EntryTime) " +
                                         "VALUES (@Name, @Model, @Stock, @Price, @Concession, @Vendor, @VendorNumber, @EntryTime)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", name_text.Text);
                        insertCmd.Parameters.AddWithValue("@Model", modal_text.Text);
                        insertCmd.Parameters.AddWithValue("@Stock", int.Parse(stock_text.Text));
                        insertCmd.Parameters.AddWithValue("@Price", decimal.Parse(price_text.Text));
                        insertCmd.Parameters.AddWithValue("@Concession", decimal.Parse(concession_text.Text));
                        insertCmd.Parameters.AddWithValue("@Vendor", vendor_txt.Text);
                        insertCmd.Parameters.AddWithValue("@VendorNumber", vendorNumber_txt.Text); // New field
                        insertCmd.Parameters.AddWithValue("@EntryTime", entryTimepicker.Value);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Mobile added successfully!");
                    }

                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
           
            modal_text.Clear();
            stock_text.Clear();
            price_text.Clear();
            concession_text.Clear();
            vendor_txt.Clear();
            vendorNumber_txt.Clear();
            entryTimepicker.Value = DateTime.Now;


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Delete_mobile delete_Mobile = new Delete_mobile();
            delete_Mobile.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            update_mobile update_mobile = new update_mobile();
            update_mobile.Show();
        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string vendorName = vendor_txt.Text.Trim();
            string vendorNumber = vendorNumber_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(vendorName) || string.IsNullOrWhiteSpace(vendorNumber))
            {
                MessageBox.Show("Vendor name and number are required to generate invoice.");
                return;
            }

            List<(string Name, string Model, decimal Price)> mobiles = new List<(string, string, decimal)>();
            decimal totalPrice = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Model, Price FROM ADD_MOBILE WHERE Vendor = @Vendor AND VendorNumber = @VendorNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Vendor", vendorName);
                    cmd.Parameters.AddWithValue("@VendorNumber", vendorNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string model = reader["Model"].ToString();
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            mobiles.Add((name, model, price));
                            totalPrice += price;
                        }
                    }
                }
            }

            if (mobiles.Count == 0)
            {
                MessageBox.Show("No mobile records found for the specified vendor.");
                return;
            }

            StringBuilder invoiceText = new StringBuilder();
            invoiceText.AppendLine("   AL BARKAT MOBILE           ");
            invoiceText.AppendLine("(Address: AL AZIZ MARKET)");
            invoiceText.AppendLine("-----------------------------------------------");
            invoiceText.AppendLine($"Vendor: {vendorName}");            
            invoiceText.AppendLine($"Vendor Number: {vendorNumber}");
            invoiceText.AppendLine("-----------------------------------------------");
            invoiceText.AppendLine("Name\t\tModel\t\tPrice");
            invoiceText.AppendLine("-----------------------------------------------");

            foreach (var mobile in mobiles)
            {
                invoiceText.AppendLine($"{mobile.Name.PadRight(15)}{mobile.Model.PadRight(15)} RS{mobile.Price:N2}".PadRight(10));

            }

            invoiceText.AppendLine("-----------------------------------------------");
            invoiceText.AppendLine($"Total Amount to Pay: RS{totalPrice:N2}/-");
            invoiceText.AppendLine("                                      ");
            invoiceText.AppendLine("                                      ");
            invoiceText.AppendLine("                                      ");
            invoiceText.AppendLine("   Thank You For Supporting");
            invoiceText.AppendLine("        Local Bussiness");

            // Open the invoice form
            invoice invoiceForm = new invoice(invoiceText.ToString());
            invoiceForm.Show();
        }
}
    }