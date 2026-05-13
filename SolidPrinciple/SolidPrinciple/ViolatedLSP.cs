namespace SolidPrinciple
{
    public class Discount
    {
        public virtual decimal Amount { get; set; }
        public virtual decimal Percentage { get; set; }

        public virtual decimal CalculateFinalPrice(decimal originalPrice)
        {
            return originalPrice - Amount - (originalPrice * Percentage / 100);
        }
    }
    public class LoyaltyDiscountt : Discount
    {
        public override decimal Amount
        {
            get => 0;
            set { } // Ignore it
        }
    }


}
