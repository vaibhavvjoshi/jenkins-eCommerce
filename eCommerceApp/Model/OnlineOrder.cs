using eCommerceApp.Services;
using eCommerceApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Model
{
    public class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;

        public OnlineOrder(ShoppingCart cart, PaymentDetails paymentDetails)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _reservationService = new ReservationService();
            _paymentProcessor = new PaymentProcessor();            
            _notificationService = new NotificationService();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount());

            _reservationService.ReserveInventory(_cart.Items);

            _notificationService.NotifyCustomerOrderCreated(_cart);

            base.Checkout();
        }
    }
}
