using eCommerceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Services.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(ShoppingCart cart);
    }
}
