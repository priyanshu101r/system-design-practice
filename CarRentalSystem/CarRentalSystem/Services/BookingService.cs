using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public class BookingService : IBookingService
    {
        private readonly IVichleService vichleService;

        public List<Booking> Bookings { get; set; }
        public BookingService(IVichleService vichleService)
        {
            this.vichleService = vichleService;

        }

        public Booking CreateBooking(Booking req)
        {
            // Logic to create a booking
            bool isAvialbe = vichleService.IsVichleAvailableForBook(req.VichleNo);
            var vichle = vichleService.GetVichleById(req.VichleNo);
            if (isAvialbe)
            {

                if (Bookings == null)
                    Bookings = new List<Booking>();

                req.BookingStatus = Enums.BookingStatus.Booked;

                req.BookingId = Guid.NewGuid().ToString();
                vichle.VehicleStatus = Enums.VehicleStatus.Booked;
                Bookings.Add(req);

                return req;
            }
            return req;

        }
        public string CanclledBooking(string bookingId)
        {
            var booking = Bookings.Where(x => x.BookingId == bookingId).FirstOrDefault();
            booking.BookingStatus = Enums.BookingStatus.Cancelled;
            var vichle = vichleService.GetVichleById(booking.VichleNo);
            vichle.VehicleStatus = Enums.VehicleStatus.Available;

            return $"Booking has canclled Successfully Amount will be transfferd to shortly on your disred payment method";
        }
    }
}
