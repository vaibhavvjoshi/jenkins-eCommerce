using eCommerceApp.Model.Interfaces;
using System.Collections.Generic;

namespace eCommerceApp.Model
{
    public class ShoppingCart
    {
        private readonly List<OrderItem> _items;
        private readonly IPricingCalculator _pricingCalculator;

        // Poor man's IOC
        public ShoppingCart() : this(new PricingCalculator())
        {
        }

        public ShoppingCart(IPricingCalculator pricingCalculator)
        {
            _pricingCalculator = pricingCalculator;
            _items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }

        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (OrderItem orderItem in Items)
            {
                total += _pricingCalculator.CalculatePrice(orderItem);
                // TO DO: Add rules based on requirement
            }
            return total;
        }
    }
}