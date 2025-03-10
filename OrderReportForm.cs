using System;
using System.Windows.Forms;
using Phone; // Ensure namespace matches your project

namespace SmartPhoneCustomizer
{
    public partial class OrderReportForm : Form
    {
        public OrderReportForm(string report)
        {
            InitializeComponent();
            DisplayReport(report);
        }

        private void DisplayReport(string report)
        {
            richTextBoxReport.Text = report;
        }

        private void InitializeComponent()
        {
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // richTextBoxReport
            this.richTextBoxReport.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxReport.Size = new System.Drawing.Size(560, 380);
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.Font = new System.Drawing.Font("Segoe UI", 10);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(480, 400);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // OrderReportForm
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.btnClose);
            this.Text = "Order Summary";
            this.ResumeLayout(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the report window
        }

        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.Button btnClose;
    }
}
