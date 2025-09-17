using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp4
{
    public partial class invoice : Form
    {
        private string invoiceText;
        private RichTextBox richTextBox;
        private PrintDocument printDocument;

        public invoice(string invoice)
        {
            InitializeComponent();
            InitializeComponent();
            invoiceText = invoice;
            SetupUI();
        }
        private void SetupUI()
        {
            this.Text = "Vendor Invoice - AL-BARKAT MOBILES";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(650, 750);
            this.BackColor = Color.White;

            // RichTextBox
            richTextBox = new RichTextBox
            {
                Dock = DockStyle.Top,
                Height = 600,
                ReadOnly = true,
                BackColor = Color.White,
                Font = new System.Drawing.Font("Consolas", 10),
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(richTextBox);

            // Format lines (headers red, rest black)
            string[] lines = invoiceText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                if (line.StartsWith("*") || line.StartsWith("Address") || line.StartsWith("Vendor"))
                    richTextBox.SelectionColor = Color.Red;
                else
                    richTextBox.SelectionColor = Color.Black;

                richTextBox.AppendText(line + Environment.NewLine);
            }

            // PDF Button
            Button btnPDF = new Button
            {
                Text = "Save as PDF",
                Width = 120,
                Height = 40,
                Top = 610,
                Left = 100,
                BackColor = Color.LightGray
            };
            btnPDF.Click += BtnPDF_Click;
            this.Controls.Add(btnPDF);

            // Print Button
            Button btnPrint = new Button
            {
                Text = "Print",
                Width = 120,
                Height = 40,
                Top = 610,
                Left = 250,
                BackColor = Color.LightGray
            };
            btnPrint.Click += BtnPrint_Click;
            this.Controls.Add(btnPrint);

            // PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog
            {
                Document = printDocument
            };

            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Vendor_Invoice.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (Document doc = new Document(PageSize.A4, 25, 25, 25, 25))
                        {
                            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            string[] lines = invoiceText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                            foreach (string line in lines)
                            {
                                var font = (line.StartsWith("AL BARKAT") || line.StartsWith("Address") || line.StartsWith("Vendor")) ?
     FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.RED) :
     line.StartsWith("Total Amount") ?
     FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.GREEN) :
     FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                            }

                            doc.Close();
                            writer.Close();
                        }
                    }

                    MessageBox.Show("Invoice saved as PDF successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving PDF: " + ex.Message);
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string[] lines = invoiceText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            System.Drawing.Font textStyle = new System.Drawing.Font("Consolas", 10);
            float lineHeight = textStyle.GetHeight(e.Graphics);
            float y = e.MarginBounds.Top;

            foreach (string line in lines)
            {
                float lineWidth = e.Graphics.MeasureString(line, textStyle).Width;
                float x = e.MarginBounds.Left + (e.MarginBounds.Width - lineWidth) / 2;
                e.Graphics.DrawString(line, textStyle, Brushes.Black, x, y);
                y += lineHeight;
            }
        }

        private void invoice_Load(object sender, EventArgs e)
        {

        }
    }
}
