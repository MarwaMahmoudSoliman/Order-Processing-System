using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class OrderStatus
    {
        public event EventHandler OrderUpdated;
        public void UpdateOrder()
        {
            OrderUpdated?.Invoke(this, EventArgs.Empty);
           
        }
    }

    public class CustomerNotification
    {
        public void Update(object sender, EventArgs e)
        {
            MessageBox.Show("Customer notified: Your order status has changed.");
        }
    }

    public class AdminDashboard
    {
        public void Update(object sender, EventArgs e)
        {
            MessageBox.Show("Admin notified: Order status updated.");
        }
    }

}
