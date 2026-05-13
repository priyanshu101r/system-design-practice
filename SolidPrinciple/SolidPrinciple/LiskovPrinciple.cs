namespace SolidPrinciple
{
    public interface IDiscount
    {
        decimal CalculateFinalPrice(decimal originalPrice);
    }

    public class FlatDiscount : IDiscount
    {
        public decimal Amount { get; set; }
        public decimal CalculateFinalPrice(decimal originalPrice)
            => originalPrice - Amount;
    }
    //if later any new type of discount interduced then we can do like this...
    public class LoyaltyDiscount : IDiscount
    {
        public decimal Percentage { get; set; }
        public decimal CalculateFinalPrice(decimal originalPrice)
            => originalPrice - (originalPrice * Percentage / 100);
    }
    //Now each class only does what it promises, and you avoid misleading behavior.
}
