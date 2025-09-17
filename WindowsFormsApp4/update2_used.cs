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
    public partial class update2_used : Form
    {
        string connectionString = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string slectedName;
        private string slectedModel;

        public update2_used(string slectedName, string slectedModel)
        {
            InitializeComponent();
            this.slectedName = slectedName;
            this.slectedModel = slectedModel;   
        }

        private void update2_used_Load(object sender, EventArgs e)
        {
            name_txt.Text = slectedName;
            model_txt.Text = slectedModel;

            name_txt.ReadOnly = true;
            model_txt.ReadOnly = true;
        }

        private void update2_Click(object sender, EventArgs e)
        {
            string stock = stock_txt.Text.Trim();
            string price = price_txt.Text.Trim();
            string concession = concession_txt.Text.Trim();

            if (string.IsNullOrEmpty(slectedName) || string.IsNullOrEmpty(slectedModel))
            {
                MessageBox.Show("Missing Name or Model.");
                return;
            }

            string setClause = "";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(stock))
            {
                setClause += "Stock = @Stock";
                parameters.Add(new SqlParameter("@Stock", stock));
            }

            if (!string.IsNullOrEmpty(price))
            {
                if (setClause.Length > 0) setClause += ", ";
                setClause += "Price = @Price";
                parameters.Add(new SqlParameter("@Price", price));
            }

            if (!string.IsNullOrEmpty(concession))
            {
                if (setClause.Length > 0) setClause += ", ";
                setClause += "Concession = @Concession";
                parameters.Add(new SqlParameter("@Concession", concession));
            }

            if (string.IsNullOrEmpty(setClause))
            {
                MessageBox.Show("Please enter at least one field to update.");
                return;
            }

            string query = $"UPDATE used_mobile SET {setClause} WHERE Name = @Name AND Model = @Model";
            parameters.Add(new SqlParameter("@Name", slectedName));
            parameters.Add(new SqlParameter("@Model", slectedModel));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }


                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Mobile updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No matching mobile found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating mobile: " + ex.Message);
                }
            }
        }

        private void model_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
