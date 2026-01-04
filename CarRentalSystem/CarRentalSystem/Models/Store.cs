namespace CarRentalSystem.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactNumber { get; set; }
        public Company Company { get; set; }
        public List<Vichle> Vichles { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
