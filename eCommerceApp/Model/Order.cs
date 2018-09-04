using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace eCommerceApp.Model
{
    public abstract class Order
    {
        protected readonly ShoppingCart _cart;

        protected Order(ShoppingCart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // TO DO: Add order details into database
        }
    }                
}