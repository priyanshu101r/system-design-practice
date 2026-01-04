namespace CarRentalSystem.PaymentStrategy
{
    public class CardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine(amount + " paid using Card Payment.");
        }
    }
}
