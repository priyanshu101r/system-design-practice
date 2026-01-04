namespace CarRentalSystem.PricingStrategy
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(DateTime start, DateTime end);
    }
}
