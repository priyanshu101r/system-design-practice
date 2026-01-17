namespace ParkingSpotDesign.Modal
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public string ParkingSpotId { get; set; }
        public Vichle vichle { get; set; }
        public long TicketPrice { get; set; }
    }
}
