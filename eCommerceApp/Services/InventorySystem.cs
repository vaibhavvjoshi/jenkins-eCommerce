using System;

namespace eCommerceApp.Services
{
    public class InventorySystem
    {
        public void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}