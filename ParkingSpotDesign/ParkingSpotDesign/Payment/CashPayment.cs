using ParkingSpotDesign.Strategy;

namespace ParkingSpotDesign.Payment
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"paid {amount} using cash");
        }
    }
}
