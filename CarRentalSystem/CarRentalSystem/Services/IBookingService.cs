using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public interface IBookingService
    {
        Booking CreateBooking(Booking req);
        string CanclledBooking(string bookingId);
    }
}
