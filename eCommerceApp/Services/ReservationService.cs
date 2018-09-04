using eCommerceApp.Model;
using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Services
{
    public class ReservationService : IReservationService
    {
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            //TO DO: Update inventory details at the backend database
            throw new NotImplementedException();
        }
    }
}
