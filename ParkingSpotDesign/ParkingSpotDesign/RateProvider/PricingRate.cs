namespace ParkingSpotDesign.RateProvider
{
    public class PricingRate
    {
        public decimal RatePerHour { get; set; }
        public decimal RatePerMinute { get; set; }
        public PricingRate(decimal ratePerHour, decimal ratePerMinute)
        {
            RatePerHour = ratePerHour;
            RatePerMinute = ratePerMinute;
        }
    }
}
