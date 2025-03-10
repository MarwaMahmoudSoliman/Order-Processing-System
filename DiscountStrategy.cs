using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }
 
    public class DiscountStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 0.9m; // 10% discount
        }
    }

    public class DynamicPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 1.05m; // 5% increase
        }
    }

    public class PricingContext
    {
        private IPricingStrategy _strategy;
        public void SetStrategy(IPricingStrategy strategy)
        {
            _strategy = strategy;
        }
        public decimal GetFinalPrice(decimal basePrice)
        {
            if (_strategy != null)
                return _strategy.CalculatePrice(basePrice);
            return basePrice;
        }
    }

}
