namespace SmartPhoneCustomizer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtProcessor;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.CheckBox chkWarranty;
        private System.Windows.Forms.CheckBox chkEngraving;
        private System.Windows.Forms.Button btnBuildOrder;
        private System.Windows.Forms.Button btnApplyExtras;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.ComboBox cmbPricingStrategy;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblPricingStrategy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.chkWarranty = new System.Windows.Forms.CheckBox();
            this.chkEngraving = new System.Windows.Forms.CheckBox();
            this.btnBuildOrder = new System.Windows.Forms.Button();
            this.btnApplyExtras = new System.Windows.Forms.Button();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.cmbPricingStrategy = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblPricingStrategy = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Main Form Properties
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "SmartPhone Customizer";
        
    
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.BackgroundImage = System.Drawing.Image.FromFile("D:\\op.png");
            this.BackgroundImageLayout = ImageLayout.Stretch; 

            // Example Label
    

            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Font Styling
            var headerFont = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            var labelFont = new System.Drawing.Font("Segoe UI", 10);
            var buttonFont = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Model Label
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(30, 30);
            this.lblModel.Name = "lblModel";
            this.lblModel.Text = "Model:";
            this.lblModel.Font = labelFont;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Model TextBox
            this.txtModel.Location = new System.Drawing.Point(180, 30);
            this.txtModel.Size = new System.Drawing.Size(250, 30);
            this.txtModel.Font = labelFont;
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // Processor Label
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(30, 80);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Text = "Processor:";
            this.lblProcessor.Font = labelFont;       
            this.lblProcessor.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Processor TextBox
            this.txtProcessor.Location = new System.Drawing.Point(180, 80);
            this.txtProcessor.Size = new System.Drawing.Size(250, 30);
            this.txtProcessor.Font = labelFont;
            this.txtProcessor.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // RAM Label
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(30, 130);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Text = "RAM (GB):";
            this.lblRAM.Font = labelFont;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // RAM TextBox
            this.txtRAM.Location = new System.Drawing.Point(180, 130);
            this.txtRAM.Size = new System.Drawing.Size(250, 30);
            this.txtRAM.Font = labelFont;
            this.txtRAM.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // Storage Label
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(30, 180);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Text = "Storage (GB):";
            this.lblStorage.Font = labelFont;
            this.lblStorage.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Storage TextBox
            this.txtStorage.Location = new System.Drawing.Point(180, 180);
            this.txtStorage.Size = new System.Drawing.Size(250, 30);
            this.txtStorage.Font = labelFont;
            this.txtStorage.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Warranty Checkbox
            this.chkWarranty.Location = new System.Drawing.Point(30, 230);
            this.chkWarranty.Name = "chkWarranty";
            this.chkWarranty.Text = "Extended Warranty (+$50)";
            this.chkWarranty.Font = labelFont;
            this.chkWarranty.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // Engraving Checkbox
            this.chkEngraving.Location = new System.Drawing.Point(250, 230);
            this.chkEngraving.Name = "chkEngraving";
            this.chkEngraving.Text = "Engraving (+$30)";
            this.chkEngraving.Font = labelFont;
            this.chkEngraving.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // Pricing Strategy Label
            // Pricing Strategy Label (Bold Font)
            this.lblPricingStrategy.AutoSize = true;
            this.lblPricingStrategy.Location = new System.Drawing.Point(30, 280);
            this.lblPricingStrategy.Name = "lblPricingStrategy";
            this.lblPricingStrategy.Text = "Pricing Strategy:";
            this.lblPricingStrategy.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);


            // Pricing Strategy ComboBox
            this.cmbPricingStrategy.Location = new System.Drawing.Point(180, 280);
            this.cmbPricingStrategy.Name = "cmbPricingStrategy";
            this.cmbPricingStrategy.Size = new System.Drawing.Size(250, 30);
            this.cmbPricingStrategy.Font = labelFont;
            this.cmbPricingStrategy.Items.AddRange(new object[] { "Standard", "Discount", "Premium" });
            this.cmbPricingStrategy.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            // Build Order Button
            this.btnBuildOrder.Location = new System.Drawing.Point(30, 350);
            this.btnBuildOrder.Size = new System.Drawing.Size(140, 50); // Increased size
            this.btnBuildOrder.Name = "btnBuildOrder";
            this.btnBuildOrder.Text = "🔨 Build Order";
            this.btnBuildOrder.Font = buttonFont;
            this.btnBuildOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuildOrder.ForeColor = System.Drawing.Color.White;
            this.btnBuildOrder.Click += new System.EventHandler(this.btnBuildOrder_Click);

            // Apply Extras Button
            this.btnApplyExtras.Location = new System.Drawing.Point(190, 350);
            this.btnApplyExtras.Size = new System.Drawing.Size(140, 50); // Increased size
            this.btnApplyExtras.Name = "btnApplyExtras";
            this.btnApplyExtras.Text = "➕ Apply Extras";
            this.btnApplyExtras.Font = buttonFont;
            this.btnApplyExtras.BackColor = System.Drawing.Color.SteelBlue;
            this.btnApplyExtras.ForeColor = System.Drawing.Color.White;
            this.btnApplyExtras.Click += new System.EventHandler(this.btnApplyExtras_Click);

            // Process Order Button
            this.btnProcessOrder.Location = new System.Drawing.Point(350, 350);
            this.btnProcessOrder.Size = new System.Drawing.Size(140, 50); // Increased size
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Text = "🚚 Process Order";
            this.btnProcessOrder.Font = buttonFont;
            this.btnProcessOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProcessOrder.ForeColor = System.Drawing.Color.White;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);

            //// Build Order Button
            //this.btnBuildOrder.Location = new System.Drawing.Point(30, 350);
            //this.btnBuildOrder.Name = "btnBuildOrder";
            //this.btnBuildOrder.Text = "🔨 Build Order";
            //this.btnBuildOrder.Font = buttonFont;
            //this.btnBuildOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            //this.btnBuildOrder.ForeColor = System.Drawing.Color.White;
            //this.btnBuildOrder.Click += new System.EventHandler(this.btnBuildOrder_Click);

            //// Apply Extras Button
            //this.btnApplyExtras.Location = new System.Drawing.Point(180, 350);
            //this.btnApplyExtras.Name = "btnApplyExtras";
            //this.btnApplyExtras.Text = "➕ Apply Extras";
            //this.btnApplyExtras.Font = buttonFont;
            //this.btnApplyExtras.BackColor = System.Drawing.Color.SteelBlue;
            //this.btnApplyExtras.ForeColor = System.Drawing.Color.White;
            //this.btnApplyExtras.Click += new System.EventHandler(this.btnApplyExtras_Click);

            //// Process Order Button
            //this.btnProcessOrder.Location = new System.Drawing.Point(330, 350);
            //this.btnProcessOrder.Name = "btnProcessOrder";
            //this.btnProcessOrder.Text = "🚚 Process Order";
            //this.btnProcessOrder.Font = buttonFont;
            //this.btnProcessOrder.BackColor = System.Drawing.Color.DarkOrange;
            //this.btnProcessOrder.ForeColor = System.Drawing.Color.White;
            //this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);

            // Add Controls to Form
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.txtProcessor);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.chkWarranty);
            this.Controls.Add(this.chkEngraving);
            this.Controls.Add(this.lblPricingStrategy);
            this.Controls.Add(this.cmbPricingStrategy);
            this.Controls.Add(this.btnBuildOrder);
            this.Controls.Add(this.btnApplyExtras);
            this.Controls.Add(this.btnProcessOrder);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
