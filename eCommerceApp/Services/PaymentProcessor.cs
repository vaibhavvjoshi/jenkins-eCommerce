using eCommerceApp.Model;
using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Services
{
    internal class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            //TO DO provide credit card screen to redirect to payment gateway navigation
            throw new NotImplementedException();
        }
    }
}
