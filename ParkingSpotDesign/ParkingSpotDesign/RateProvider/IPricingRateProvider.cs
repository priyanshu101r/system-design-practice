using ParkingSpotDesign.Enums;

namespace ParkingSpotDesign.RateProvider
{
    public interface IPricingRateProvider
    {
        PricingRate GetRate(VichleType vichleType);
    }
}
