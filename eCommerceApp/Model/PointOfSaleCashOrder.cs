using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Model
{
    public class PointOfSaleCashOrder : Order
    {
        public PointOfSaleCashOrder(ShoppingCart cart)
            : base(cart)
        {
        }
    }
}
