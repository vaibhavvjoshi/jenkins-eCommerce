namespace eCommerceApp.Model.Interfaces
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}