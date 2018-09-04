using eCommerceApp.Services;
using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Model
{
    public class PointOfSaleCreditOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;

        public PointOfSaleCreditOrder(ShoppingCart cart, PaymentDetails paymentDetails)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount());

            base.Checkout();
        }
    }
}
