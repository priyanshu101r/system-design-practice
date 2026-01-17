using ParkingSpotDesign.Enums;

namespace ParkingSpotDesign.RateProvider
{
    public class DefaultPricingRateProvider : IPricingRateProvider
    {
        public PricingRate GetRate(VichleType vichleType)
        {
            return vichleType switch
            {
                VichleType.twowheeler => new PricingRate(10, 1),
                VichleType.fourwheeler => new PricingRate(20, 2),
                VichleType.HeavyVehicle => new PricingRate(30, 3),
                _ => throw new Exception("Invalid type")
            };
        }
    }
}
