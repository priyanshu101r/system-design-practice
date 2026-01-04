using CarRentalSystem.Models;
using CarRentalSystem.Notification;
using CarRentalSystem.PaymentStrategy;
using CarRentalSystem.PricingStrategy;
using CarRentalSystem.Services;

namespace CarRentalSystem.ApplicationServices
{
    public class BookingApplicationService
    {
        private readonly IPricingStrategy pricingStrategy;
        private readonly IPaymentStrategy paymentStrategy;
        private readonly IBookingService bookingService;
        public readonly NotificationManager notificationManager;
        public BookingApplicationService(IBookingService bookingService, IPricingStrategy pricingStrategy, IPaymentStrategy paymentStrategy, NotificationManager notificationManager)

        {
            this.pricingStrategy = pricingStrategy;
            this.paymentStrategy = paymentStrategy;
            this.bookingService = bookingService;
            this.notificationManager = notificationManager;
        }
        public void BookVichle(Booking req)
        {
            var obj = bookingService.CreateBooking(req);
            decimal cost = pricingStrategy.CalculatePrice(obj.BookingDate, req.ReturnDate);
            paymentStrategy.Pay(cost);
            notificationManager.NotifyAll(new NotificationMessage
            {
                UserId = obj.UserId,
                Message = $"Booking Confirmed with BookingId: {obj.BookingId} and Total Cost: {cost}"
            });
        }
    }
}
