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
    public partial class addcustomer : Form
    {
        string connection_string = "Data Source=DESKTOP-70VF5P1\\SQLEXPRESS;Initial Catalog=MOBILESHOPDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private DataTable cartTable = new DataTable();

        public addcustomer()
        {
            InitializeComponent();
            cmbMobileType.Items.Add("New");
            cmbMobileType.Items.Add("Used");
            cmbMobileType.SelectedIndex = 0;
            cmbMobileType.SelectedIndexChanged += (s, e) => fromMobiles();
            InitializeCart();

            
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            mobile_txt.SelectedIndexChanged += mobile_txt_SelectedIndexChanged;
            modal_txt.SelectedIndexChanged += modal_txt_SelectedIndexChanged;
        }

        private void InitializeCart()
        {
            cartTable.Columns.Add("Mobile");
            cartTable.Columns.Add("Model");
            cartTable.Columns.Add("Amount");
            cartTable.Columns.Add("Quantity");
            cartTable.Columns.Add("Type", typeof(string));

            dgvCart.DataSource = cartTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fromMobiles()
        {
            mobile_txt.Items.Clear();
            modal_txt.Items.Clear();

            string mobileType = cmbMobileType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mobileType)) return;

            string query = "";

            if (mobileType == "New")
                query = "SELECT Name, Model FROM ADD_MOBILE";
            else if (mobileType == "Used")
                query = "SELECT Name, Model FROM USED_MOBILE";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    HashSet<string> uniqueMobileNames = new HashSet<string>();
                    HashSet<string> uniqueMobileModels = new HashSet<string>();

                    while (reader.Read())
                    {
                        uniqueMobileNames.Add(reader["Name"].ToString());
                        uniqueMobileModels.Add(reader["Model"].ToString());
                    }

                    foreach (var name in uniqueMobileNames)
                        mobile_txt.Items.Add(name);
                    foreach (var model in uniqueMobileModels)
                        modal_txt.Items.Add(model);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }


        private void addcustomer_Load(object sender, EventArgs e)
        {
            cmbMobileType.SelectedIndex = 0;

            fromMobiles();
            purchaseDatePicker.Format = DateTimePickerFormat.Custom;
            purchaseDatePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            purchaseDatePicker.Value = DateTime.Now;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete d = new delete();
            d.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void modal_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modal_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mobile_txt.SelectedItem == null || modal_txt.SelectedItem == null || cmbMobileType.SelectedItem == null)
                return;

            string selectedMobileName = mobile_txt.SelectedItem.ToString();
            string selectedModel = modal_txt.SelectedItem.ToString();
            string mobileType = cmbMobileType.SelectedItem.ToString();
            string tableName = mobileType == "New" ? "ADD_MOBILE" : "USED_MOBILE";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    string fetchDiscountQuery = $"SELECT Concession FROM {tableName} WHERE Name = @MobileName AND Model = @Model";
                    using (SqlCommand cmd = new SqlCommand(fetchDiscountQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileName", selectedMobileName);
                        cmd.Parameters.AddWithValue("@Model", selectedModel);

                        object concession = cmd.ExecuteScalar();
                        if (concession != null)
                        {
                            amount_txt.Text = concession.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Concession not found for selected mobile.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching price: " + ex.Message);
                }
            }
        }
    


        private void mobile_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMobileName = mobile_txt.SelectedItem.ToString();
            modal_txt.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    string mobileType = cmbMobileType.SelectedItem.ToString();
                    string tableName = mobileType == "New"
                        ? "ADD_MOBILE"
                        : "USED_MOBILE";

                    string fetchModelQuery =
                        $"SELECT DISTINCT Model FROM {tableName} WHERE Name = @MobileName";

                    using (SqlCommand cmd = new SqlCommand(fetchModelQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MobileName", selectedMobileName);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            modal_txt.Items.Add(reader["Model"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    


        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_txt.Text) || id_txt.Text.Length != 13)
            {
                MessageBox.Show("Please enter a valid 13-digit CNIC to update.");
                return;
            }

            long parsedId;
            if (!long.TryParse(id_txt.Text.Trim(), out parsedId))
            {
                MessageBox.Show("Invalid CNIC format.");
                return;
            }

            updatecustomerrrr updateForm = new updatecustomerrrr(parsedId);
            updateForm.Show();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbMobileType.SelectedItem == null ||
        string.IsNullOrWhiteSpace(mobile_txt.Text) ||
        string.IsNullOrWhiteSpace(modal_txt.Text) ||
        string.IsNullOrWhiteSpace(amount_txt.Text) ||
        string.IsNullOrWhiteSpace(damount_txt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(amount_txt.Text.Trim(), out decimal amount) || amount < 0)
            {
                MessageBox.Show("Amount must be a valid number >= 0.");
                return;
            }

            if (!int.TryParse(damount_txt.Text.Trim(), out int qty) || qty < 1)
            {
                MessageBox.Show("Quantity must be a whole number >= 1.");
                return;
            }

            string mobileType = cmbMobileType.SelectedItem.ToString();

            DataRow row = cartTable.NewRow();
            row["Mobile"] = mobile_txt.Text;
            row["Model"] = modal_txt.Text;
            row["Amount"] = amount;
            row["Quantity"] = qty;
            row["Type"] = mobileType;

            cartTable.Rows.Add(row);
            dgvCart.DataSource = cartTable;
        }
        

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text.Trim();
            string idNo = id_txt.Text.Trim();
            string contactNo = contact_txt.Text.Trim();
            DateTime purchaseDate = purchaseDatePicker.Value;

            if (string.IsNullOrWhiteSpace(contactNo) || contactNo.Length != 11 || !contactNo.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 11-digit contact number.");
                return;
            }

            if (idNo.Length != 13 || !idNo.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 13-digit ID card number.");
                return;
            }

            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            if (cmbMobileType.SelectedItem == null)
            {
                MessageBox.Show("Please select mobile type (New or Used).");
                return;
            }

            string mobileType = cmbMobileType.SelectedItem.ToString();
            string sourceTable = mobileType == "New" ? "ADD_MOBILE" : "USED_MOBILE";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    // Insert into Customer table
                    SqlCommand insertCustomer = new SqlCommand(
                        "INSERT INTO Customer (ID_No, Name, Purchase_Date, Contact_No) OUTPUT INSERTED.CustomerID " +
                        "VALUES (@ID, @Name, @Date, @Contact)", conn, transaction);
                    insertCustomer.Parameters.AddWithValue("@ID", idNo);
                    insertCustomer.Parameters.AddWithValue("@Name", name);
                    insertCustomer.Parameters.AddWithValue("@Date", purchaseDate);
                    insertCustomer.Parameters.AddWithValue("@Contact", contactNo);

                    int customerId = (int)insertCustomer.ExecuteScalar();

                    foreach (DataRow row in cartTable.Rows)
                    {
                        string mobile = row["Mobile"].ToString();
                        string model = row["Model"].ToString();
                        decimal amount = Convert.ToDecimal(row["Amount"]);
                        int qty = Convert.ToInt32(row["Quantity"]);

                        // Stock check
                        SqlCommand checkStock = new SqlCommand($"SELECT Stock FROM {sourceTable} WHERE Model = @Model", conn, transaction);
                        checkStock.Parameters.AddWithValue("@Model", model);
                        object stockObj = checkStock.ExecuteScalar();

                        if (stockObj == null || Convert.ToInt32(stockObj) < qty)
                        {
                            throw new Exception($"Not enough stock for model: {model}");
                        }

                        // Insert into Customer_Purchase
                        SqlCommand insertPurchase = new SqlCommand(
                            "INSERT INTO Customer_Purchase (CustomerID, Mobile, Mobile_Model, Amount, D_Amount, Type) " +
                            "VALUES (@CustomerID, @Mobile, @Model, @Amount, @Qty, @Type)", conn, transaction);
                        insertPurchase.Parameters.AddWithValue("@CustomerID", customerId);
                        insertPurchase.Parameters.AddWithValue("@Mobile", mobile);
                        insertPurchase.Parameters.AddWithValue("@Model", model);
                        insertPurchase.Parameters.AddWithValue("@Amount", amount);
                        insertPurchase.Parameters.AddWithValue("@Qty", qty);
                        insertPurchase.Parameters.AddWithValue("@Type", mobileType);
                        insertPurchase.ExecuteNonQuery();

                        // Update stock
                        SqlCommand updateStock = new SqlCommand(
                            $"UPDATE {sourceTable} SET Stock = Stock - @Qty WHERE Model = @Model", conn, transaction);
                        updateStock.Parameters.AddWithValue("@Qty", qty);
                        updateStock.Parameters.AddWithValue("@Model", model);
                        updateStock.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    // Invoice generation
                    StringBuilder invoice = new StringBuilder();
                    invoice.AppendLine(" AL-BARKAT MOBILES");
                    invoice.AppendLine("     (AL AZIZ MARKET Burewala)");
                    invoice.AppendLine("-----------------------------------------------------------------");
                    invoice.AppendLine($"Customer Name: {name}");
                    invoice.AppendLine($"Contact: {contactNo}");
                    invoice.AppendLine($"CNIC: {idNo}");
                    invoice.AppendLine($"Date: {purchaseDate:dd-MM-yyyy HH:mm:ss}");
                    invoice.AppendLine("-----------------------------------------------------------------");
                    invoice.AppendLine(" Mobile      Model       Type      Price        Qty   Subtotal");
                    invoice.AppendLine("-----------------------------------------------------------------");

                    decimal total = 0;
                    foreach (DataRow row in cartTable.Rows)
                    {

                        string mobile = row["Mobile"].ToString();
                        string model = row["Model"].ToString();
                        string type = row["Type"].ToString(); // Assuming all items share one selected type
                        decimal amount = Convert.ToDecimal(row["Amount"]);
                        int qty = Convert.ToInt32(row["Quantity"]);
                        decimal subtotal = amount * qty;
                        total += subtotal;

                        invoice.AppendLine($"{mobile,-10}{model,-13}{type,-8}RS{amount,7:N2}{qty,6}{subtotal,13:N2}");

                    }

                    invoice.AppendLine("------------------------------------------------------------------");
                    invoice.AppendLine($"Total Payable: RS{total:N2}/-");
                    invoice.AppendLine("------------------------------------------------------------------");
                    invoice.AppendLine();
                    invoice.AppendLine("  Thank You For");
                    invoice.AppendLine("  Your Purchase");

                    invoicecustomer ic = new invoicecustomer(invoice.ToString());
                    ic.BackColor = Color.White;
                    ic.Show();
                    MessageBox.Show("Customer and mobile entries added successfully.");
                    cartTable.Clear();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
