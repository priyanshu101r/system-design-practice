using ParkingSpotDesign.Modal;
using ParkingSpotDesign.Service;

namespace ParkingSpotDesign.Gate
{
    public class EntranceGate
    {
        public IParkingSpotManager parkingSpotManager;
        public EntranceGate(IParkingSpotManager parkingSpotManager)
        {
            this.parkingSpotManager = parkingSpotManager;
        }

        public Ticket Enter(Vichle vichle)
        {
            var spot = parkingSpotManager.AssignSpot(vichle.VichleType);
            if (spot == null)
            {
                throw new Exception("No Spot Available");
            }

            var ticket = new Ticket
            {
                TicketId = Guid.NewGuid().ToString(),
                ParkingSpotId = spot.SpotId,
                vichle = vichle,
                EntryTime = DateTime.Now
            };
            OpenGate();
            return ticket;
        }
        private void OpenGate()
        {
            Console.WriteLine("Gate opened");
        }
    }
}
