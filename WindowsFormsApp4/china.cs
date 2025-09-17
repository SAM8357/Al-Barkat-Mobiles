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
    public partial class china : Form
    {
        public china()
        {
            InitializeComponent();
            LoadOtherMobiles();
        }

        private void china_Load(object sender, EventArgs e)
        {

        }
        private void LoadOtherMobiles()
        {
            string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            string query = @"SELECT MobileID, Name, Model, Stock, Price, Concession, Vendor, VendorNumber, EntryTime 
                     FROM ADD_MOBILE 
                     WHERE Name IN ('VIVO', 'OPPO', 'INFINIX', 'TECHNO')";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int y = 20;

                    while (reader.Read())
                    {
                        string brand = reader["Name"].ToString();
                        string model = reader["Model"].ToString();
                        string stock = reader["Stock"].ToString();
                        string price = string.Format("{0:C}", reader["Price"]);
                        string concession = string.Format("{0:C}", reader["Concession"]);
                        string vendor = reader.IsDBNull(reader.GetOrdinal("Vendor")) ? "N/A" : reader["Vendor"].ToString();
                        string vendorNumber = reader.IsDBNull(reader.GetOrdinal("VendorNumber")) ? "N/A" : reader["VendorNumber"].ToString();
                        string entryTime = reader.IsDBNull(reader.GetOrdinal("EntryTime")) ? "N/A" : Convert.ToDateTime(reader["EntryTime"]).ToString("g");

                        // Row 1
                        CreateLabel("Brand:", 20, y);
                        CreateTextBox(brand, 100, y);

                        CreateLabel("Model:", 320, y);
                        CreateTextBox(model, 400, y);

                        CreateLabel("Stock:", 620, y);
                        CreateTextBox(stock, 700, y);

                        CreateLabel("Come_Price:", 920, y);
                        CreateTextBox(price, 1020, y);

                        y += 30;

                        // Row 2
                        CreateLabel("Sale_Price:", 20, y);
                        CreateTextBox(concession, 100, y);

                        CreateLabel("Vendor:", 320, y);
                        CreateTextBox(vendor, 400, y);

                        CreateLabel("Vendor No:", 620, y); // New
                        CreateTextBox(vendorNumber, 720, y); // New

                        y += 30;

                        // Row 3
                        CreateLabel("DateTime:", 20, y);
                        CreateTextBox(entryTime, 100, y);

                        y += 40;
                    }
                }

                this.AutoScroll = true;
            }
        }


        private void CreateLabel(string text, int x, int y)
        {
            Label lbl = new Label
            {
                Text = text,
                Location = new Point(x, y + 5),
                Size = new Size(80, 20),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            this.Controls.Add(lbl);
        }



        private void CreateTextBox(string text, int x, int y)
        {
            TextBox txt = new TextBox
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(180, 25),
                ReadOnly = true
            };
            this.Controls.Add(txt);
        }
    }
}
