using eCommerceApp.Model.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace eCommerceApp.Model
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IDiscountRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IDiscountRule>();          
            _pricingRules.Add(new BuyTwoGetOneFree());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}