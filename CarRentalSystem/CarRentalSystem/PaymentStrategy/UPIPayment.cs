namespace CarRentalSystem.PaymentStrategy
{
    public class UPIPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + " paid using UPI Payment.");
        }
    }
}
