using System;
using System.Windows.Forms;
using Phone; 

namespace SmartPhoneCustomizer
{
    public partial class ExtrasReportForm : Form
    {
        public ExtrasReportForm(string report)
        {
            InitializeComponent();
            DisplayReport(report);
        }

        private void DisplayReport(string report)
        {
            richTextBoxReport.Text = report; // Display the formatted report
        }

        private void InitializeComponent()
        {
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // richTextBoxReport
            this.richTextBoxReport.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxReport.Size = new System.Drawing.Size(580, 400);
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.Font = new System.Drawing.Font("Segoe UI", 10);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(500, 420);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ExtrasReportForm
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.btnClose);
            this.Text = "Extras Applied Report";
            this.ResumeLayout(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.Button btnClose;
    }
}
