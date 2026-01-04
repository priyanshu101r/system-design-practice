using CarRentalSystem.Enums;

namespace CarRentalSystem.Models
{
    public class Booking
    {
        public string BookingId { get; set; }
        public string StoreId { get; set; }
        public string UserId { get; set; }
        public string VichleNo { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsOnDoorDelivery { get; set; }
        public string DileveryAddress { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public BookingStatus BookingStatus { get; set; }
    }
}
