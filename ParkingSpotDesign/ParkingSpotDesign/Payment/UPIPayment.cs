using ParkingSpotDesign.Strategy;

namespace ParkingSpotDesign.Payment
{
    public class UPIPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"paid {amount} using UPI");
        }
    }
}
