using eCommerceApp.Model.Interfaces;
namespace eCommerceApp.Model
{
    public class BuyTwoGetOneFree : IDiscountRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("B2G1");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            // TO DO: Get order item's price per quantity, currently it's considered to be $1 per item
            total += item.Quantity * 1m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * 1m;
            return total;
        }
    }
}