using System;

namespace eCommerceApp.Model.Interfaces
{
    public interface IDiscountRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}