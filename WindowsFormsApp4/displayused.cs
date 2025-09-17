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
    public partial class displayused : Form
    {
        public displayused()
        {
            InitializeComponent();
            LoadUsedMobiles();
        }
        private void LoadUsedMobiles()
        {
            string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT Name, Model, Stock, Price, Concession FROM used_mobile";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int y = 20; // Starting vertical position

                while (reader.Read())
                {
                    // Name
                    CreateLabel("Brand:", 20, y);
                    CreateTextBox(reader["Name"].ToString(), 100, y);

                    // Model
                    CreateLabel("Model:", 300, y);
                    CreateTextBox(reader["Model"].ToString(), 380, y);

                    // Stock
                    CreateLabel("Stock:", 580, y);
                    CreateTextBox(reader["Stock"].ToString(), 660, y);

                    // Price
                    CreateLabel("Price:", 860, y);
                    CreateTextBox(string.Format("{0:C}", reader["Price"]), 940, y);

                    // Concession
                    CreateLabel("Concession:", 1140, y);
                    CreateTextBox(string.Format("{0:C}", reader["Concession"]), 1250, y);

                    y += 60; // Space between entries
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
                Size = new Size(75, 20),
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
                Size = new Size(160, 25),
                ReadOnly = true
            };
            this.Controls.Add(txt);
        }
    
        private void displayused_Load(object sender, EventArgs e)
        {

        }
    }
}
