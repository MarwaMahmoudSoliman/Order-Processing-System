public interface IOrderMediator
{
    void Notify(object sender, string ev);
}

public class OrderMediator : IOrderMediator
{
    public PaymentModule PaymentModule { get; set; }
    public InventoryModule InventoryModule { get; set; }
    public ShippingModule ShippingModule { get; set; }

    public void Notify(object sender, string ev)
    {
        if (ev == "OrderPlaced")
        {
            PaymentModule?.ProcessPayment();
            InventoryModule?.UpdateInventory();
            ShippingModule?.ScheduleShipping();
        }
    }
}

public class PaymentModule
{
    public void ProcessPayment()
    {
        MessageBox.Show("Payment processed successfully.");
    }
}

public class InventoryModule
{
    public void UpdateInventory()
    {
        MessageBox.Show("Inventory updated.");
    }
}

public class ShippingModule
{
    public void ScheduleShipping()
    {
        MessageBox.Show("Shipping scheduled.");
    }
}