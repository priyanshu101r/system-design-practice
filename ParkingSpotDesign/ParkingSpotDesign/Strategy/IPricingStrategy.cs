using ParkingSpotDesign.Modal;

namespace ParkingSpotDesign.Strategy
{
    public interface IPricingStrategy
    {
        public int CalculateParkingCost(Ticket ticket, DateTime entryTime, DateTime exitTime);
    }
}
