using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public class PlacedOrderHandler : CheckOutHandler
    {
        public override OrderResponse HandleRequest(OrderRequest request)
        {
            return new OrderResponse(true, "Order placed successfully.");
            Console.WriteLine("OrderExecution has done successfully.");
        }
    }
}
