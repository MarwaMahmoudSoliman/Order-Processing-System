using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Phone;

namespace SmartPhoneCustomizer
{
    public partial class MainForm : Form
    {
        private OrderMediator orderMediator;

        private OrderStatus orderStatus;
        private CustomerNotification customerNotification;
        private AdminDashboard adminDashboard;

        private PricingContext pricingContext;

        private CustomSmartphone customOrder;


        private IProduct finalProduct;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            orderMediator = new OrderMediator
            {
                PaymentModule = new PaymentModule(),
                InventoryModule = new InventoryModule(),
                ShippingModule = new ShippingModule()
            };

          
            orderStatus = new OrderStatus();
            customerNotification = new CustomerNotification();
            adminDashboard = new AdminDashboard();
            orderStatus.OrderUpdated += customerNotification.Update;
            orderStatus.OrderUpdated += adminDashboard.Update;

            
            pricingContext = new PricingContext();
        }

        private void btnBuildOrder_Click(object sender, EventArgs e)
        {
            SmartphoneBuilder builder = new SmartphoneBuilder();
            customOrder = builder
                .SetModel(txtModel.Text)
                .SetProcessor(txtProcessor.Text)
                .SetRAM(int.TryParse(txtRAM.Text, out int ram) ? ram : 4)
                .SetStorage(int.TryParse(txtStorage.Text, out int storage) ? storage : 64)
                .Build();

            // Generate a detailed report
            string report = GenerateOrderReport(customOrder);

            // Show the report in a new form
            OrderReportForm reportForm = new OrderReportForm(report);
            reportForm.Show();
        }

        // Helper method to format the order report
        private string GenerateOrderReport(CustomSmartphone order)
        {
            return $@"
******** SMARTPHONE CUSTOMIZER ********

Order Summary:

Model:      {order.Model}
Processor:  {order.Processor}
RAM:        {order.RAM} GB
Storage:    {order.Storage} GB

--------------------------------------
Order Created: {DateTime.Now}

Thank you for your order!
";
        }



        private void btnApplyExtras_Click(object sender, EventArgs e)
        {
            finalProduct = new BaseSmartphoneProduct(customOrder);

            // Apply optional extras using decorators
            if (chkWarranty.Checked)
            {
                finalProduct = new ExtendedWarrantyDecorator(finalProduct);
            }
            if (chkEngraving.Checked)
            {
                finalProduct = new EngravingDecorator(finalProduct);
            }

            // Generate the extras report
            string report = GenerateExtrasReport(finalProduct);

            // Display the report in a new window
            ExtrasReportForm reportForm = new ExtrasReportForm(report);
            reportForm.Show();
        }

        // Helper method to create a formatted extras report
        private string GenerateExtrasReport(IProduct product)
        {
            return $@"
******** EXTRAS APPLIED REPORT ********

Product Description:
{product.GetDescription()}

--------------------------------------
Total Price: ${product.GetPrice():0.00}

Date: {DateTime.Now}

Thank you for customizing your smartphone!
";
        }


        // Button to process order using the Mediator Pattern
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            orderMediator.Notify(this, "OrderPlaced");
        }

        // Button to update order status (Observer Pattern)
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            orderStatus.UpdateOrder();
        }

        // Button to calculate final price using the Strategy Pattern
        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            decimal basePrice = finalProduct != null ? finalProduct.GetPrice() : 0;
            if (cmbPricingStrategy.SelectedItem != null)
            {
                string strategy = cmbPricingStrategy.SelectedItem.ToString();
                if (strategy == "Discount")
                {
                    pricingContext.SetStrategy(new DiscountStrategy());
                }
                else if (strategy == "Dynamic")
                {
                    pricingContext.SetStrategy(new DynamicPricingStrategy());
                }
            }
            decimal finalPrice = pricingContext.GetFinalPrice(basePrice);
            MessageBox.Show("Final Price: $" + finalPrice);
        }
    }
}
