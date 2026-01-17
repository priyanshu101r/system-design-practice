using ParkingSpotDesign.Modal;
using ParkingSpotDesign.Service;
using ParkingSpotDesign.Strategy;

namespace ParkingSpotDesign.Gate
{
    public class ExistGate
    {
        public IPricingStrategy pricingStrategy;
        public IPaymentStrategy paymentStrategy;
        public IParkingSpotManager spotManger;
        public ExistGate(IPricingStrategy pricingStrategy, IPaymentStrategy paymentStrategy, IParkingSpotManager spotManger)
        {
            this.pricingStrategy = pricingStrategy;
            this.paymentStrategy = paymentStrategy;
            this.spotManger = spotManger;
        }
        public void ProcessExit(Ticket ticket, ParkingSpot spot)
        {
            var costofTicket = pricingStrategy.CalculateParkingCost(ticket, ticket.EntryTime, DateTime.Now);
            ticket.TicketPrice = costofTicket;
            paymentStrategy.Pay(costofTicket);
            spotManger.ReleaseSpot(spot.SpotId);
            OpenGate();
        }

        private void OpenGate()
        {
            Console.WriteLine("Payment has done successfully, Thank you");
        }
    }
}
