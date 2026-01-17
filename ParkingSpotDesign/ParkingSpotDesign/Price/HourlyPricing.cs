using ParkingSpotDesign.Modal;
using ParkingSpotDesign.RateProvider;
using ParkingSpotDesign.Strategy;

namespace ParkingSpotDesign.Price
{
    public class HourlyPricing : IPricingStrategy
    {
        public IPricingRateProvider rateProvider { get; set; }
        public HourlyPricing(IPricingRateProvider _rateProvider)
        {
            rateProvider = _rateProvider;
        }
        public int CalculateParkingCost(Ticket ticket, DateTime entryTime, DateTime exitTime)
        {
            TimeSpan duration = exitTime - entryTime;
            int hoursParked = (int)Math.Ceiling(duration.TotalHours);

            int ratePerHour = 0;
            var rate = rateProvider.GetRate(ticket.vichle.VichleType);
            var hours = Math.Ceiling(
            (exitTime - ticket.EntryTime).TotalHours
             );

            return Convert.ToInt32((decimal)hours * rate.RatePerHour);
        }
    }
}
