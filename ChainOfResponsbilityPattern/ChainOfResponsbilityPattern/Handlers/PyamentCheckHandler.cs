using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public class PyamentCheckHandler : CheckOutHandler
    {
        public override OrderResponse HandleRequest(OrderRequest request)
        {
            if (!IsPaymentSuccess(request))
            {
                return new OrderResponse(false, "payment has not done");
            }
            return _nextHandler.HandleRequest(request);
        }
        private bool IsPaymentSuccess(OrderRequest request)
        {
            // Perform payment check logic here
            return request.IsPaymentDoneChecked; // Placeholder return value
        }
    }
}
