using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public class AuthCheckHandler : CheckOutHandler
    {
        public override OrderResponse HandleRequest(OrderRequest request)
        {
            if (!isAuthChecked(request))
            {
                return new OrderResponse(

                     false,
                     "Authentication not passed."
                );


            }
            return _nextHandler?.HandleRequest(request);

        }
        private bool isAuthChecked(OrderRequest request)
        {
            // Perform authentication check logic here
            return request.IsAuthChecked; // Placeholder return value
        }
    }
}
