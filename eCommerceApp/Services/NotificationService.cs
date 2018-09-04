using eCommerceApp.Model;
using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Services
{
    internal class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(ShoppingCart cart)
        {
            //TO DO: Send notification email / SMS to customer
            throw new NotImplementedException();
        }
    }
}
