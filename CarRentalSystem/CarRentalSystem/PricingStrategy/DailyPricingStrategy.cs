namespace CarRentalSystem.PricingStrategy
{
    public class DailyPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(DateTime start, DateTime end)
        {
            var days = Math.Ceiling((end - start).TotalDays);
            return Convert.ToDecimal(days * 2000);
        }
    }
}
