using ParkingSpotDesign.Modal;
using ParkingSpotDesign.RateProvider;

namespace ParkingSpotDesign.Price
{
    public class MinutePricing
    {
        public IPricingRateProvider _rateProvider { get; set; }
        public MinutePricing(IPricingRateProvider rateProvider)
        {
            _rateProvider = rateProvider;
        }


        public int CalculatePrice(Ticket ticket, DateTime entryTime, DateTime exitTime)
        {
            var rate = _rateProvider.GetRate(ticket.vichle.VichleType);
            var minutes = Math.Ceiling(
            (exitTime - ticket.EntryTime).TotalMinutes
        );
            return Convert.ToInt32((decimal)minutes * rate.RatePerMinute);
        }
    }
}
