namespace CarRentalSystem.PricingStrategy
{
    internal class HourlyPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(DateTime start, DateTime end)
        {
            var hours = Math.Ceiling((end - start).TotalHours);
            return Convert.ToDecimal(hours * 200);
        }
    }
}
