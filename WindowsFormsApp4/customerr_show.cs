using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class customerr_show : Form
    {
        public customerr_show(DataRow row)
        {
            InitializeComponent();
            namelabel.Text = row["Name"].ToString();
            mobilelabel.Text = row["Mobile"].ToString();
            modallabel.Text = row["Mobile_Model"].ToString();
            amountlabel.Text = row["Amount"].ToString();
            discountlabel.Text = row["D_Amount"].ToString();
            idno.Text = row["ID_No"].ToString() ;
        }

        private void customerr_show_Load(object sender, EventArgs e)
        {

        }
    }
}
