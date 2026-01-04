namespace CarRentalSystem.PaymentStrategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
