using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class invoicecustomer : Form
    {
        private string invoiceText;
        private RichTextBox richTextBox;
        private PrintDocument printDocument;

        public invoicecustomer(string invoice)
        {
            InitializeComponent();
            invoiceText = invoice;
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Invoice - AL-BARKAT MOBILES";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(650, 750);
            this.BackColor = Color.White;

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

            string[] lines = invoiceText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
            {
                if (i < 4 || i >= lines.Length - 1)
                    richTextBox.SelectionColor = Color.Red;
                else
                    richTextBox.SelectionColor = Color.Black;

                richTextBox.AppendText(lines[i] + Environment.NewLine);
            }

            Button BtnPDF = new Button
            {
                Text = "Save as PDF",
                Width = 120,
                Height = 40,
                Top = 610,
                Left = 100,
                BackColor = Color.LightGray
            };
            BtnPDF.Click += BtnPDF_Click;
            this.Controls.Add(BtnPDF);

            Button BtnPrint = new Button
            {
                Text = "Print",
                Width = 120,
                Height = 40,
                Top = 610,
                Left = 250,
                BackColor = Color.LightGray
            };
            BtnPrint.Click += BtnPrint_Click;
            this.Controls.Add(BtnPrint);

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        
        


        private void invoicecustomer_Load(object sender, EventArgs e)
        {

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
                FileName = "Invoice.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                Document doc = null;
                PdfWriter writer = null;

                try
                {
                    fs = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    doc = new Document(PageSize.A4, 25, 25, 25, 25);
                    writer = PdfWriter.GetInstance(doc, fs);

                    doc.Open();

                    string[] lines = invoiceText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                    foreach (string line in lines)
                    {
                        var font = (line.StartsWith(" ") || line.StartsWith("-") || line.Contains("Total")) ?
                            FontFactory.GetFont(FontFactory.COURIER, 11, BaseColor.BLACK) :
                            FontFactory.GetFont(FontFactory.COURIER, 11, BaseColor.RED);

                        Paragraph p = new Paragraph(line, font)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(p);
                    }

                    MessageBox.Show("Invoice saved as PDF successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving PDF: " + ex.Message);
                }
                finally
                {
                    if (doc != null && doc.IsOpen()) doc.Close();
                    if (writer != null) writer.Close();  // Ensure writer finishes writing
                    if (fs != null) fs.Close();          // Close stream last
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
    }
       
    }

