using System;
using System.Drawing; // Required for colors
using System.Windows.Forms;

namespace SmartPhoneCustomizer
{
    public partial class OrderProcessingReportForm : Form
    {
        public OrderProcessingReportForm(string report)
        {
            InitializeComponent();
            DisplayReport(report);
        }

        private void DisplayReport(string report)
        {
            richTextBoxReport.Clear();

            // Split the report by lines
            string[] lines = report.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                if (line.Contains("Payment")) // Payment Section (Green)
                {
                    AppendColoredText(line + Environment.NewLine, Color.Green);
                }
                else if (line.Contains("Inventory")) // Inventory Section (Blue)
                {
                    AppendColoredText(line + Environment.NewLine, Color.Blue);
                }
                else if (line.Contains("Shipping")) // Shipping Section (Purple)
                {
                    AppendColoredText(line + Environment.NewLine, Color.Purple);
                }
                else // Default Text (Black)
                {
                    AppendColoredText(line + Environment.NewLine, Color.Black);
                }
            }
        }

        private void AppendColoredText(string text, Color color)
        {
            richTextBoxReport.SelectionStart = richTextBoxReport.TextLength;
            richTextBoxReport.SelectionLength = 0;
            richTextBoxReport.SelectionColor = color;
            richTextBoxReport.AppendText(text);
            richTextBoxReport.SelectionColor = richTextBoxReport.ForeColor; // Reset to default
        }

        private void InitializeComponent()
        {
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // richTextBoxReport
            this.richTextBoxReport.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxReport.Size = new System.Drawing.Size(600, 400);
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.Font = new Font("Segoe UI", 10);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(520, 420);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // OrderProcessingReportForm
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.btnClose);
            this.Text = "Order Processing Report";
            this.ResumeLayout(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the report window
        }

        private RichTextBox richTextBoxReport;
        private Button btnClose;
    }
}
