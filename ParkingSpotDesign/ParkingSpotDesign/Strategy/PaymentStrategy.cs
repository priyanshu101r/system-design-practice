namespace ParkingSpotDesign.Strategy
{
    public class PaymentStrategy
    {
        public IPaymentStrategy paymentStrategy;
        public PaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Pay(int amount)
        {
            this.paymentStrategy.Pay(amount);
        }
    }
}
