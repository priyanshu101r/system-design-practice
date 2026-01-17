using ParkingSpotDesign.Strategy;

namespace ParkingSpotDesign.Payment
{
    public class CardPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"paid {amount} using card");
        }
    }
}
