using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public class DiscuountCheckHandler : CheckOutHandler
    {
        public override OrderResponse HandleRequest(OrderRequest request)
        {
            if (!IsDiscountApplied(request))
            {
                return new OrderResponse(false, "discount has not done");
            }
            return _nextHandler.HandleRequest(request);
        }
        private bool IsDiscountApplied(OrderRequest request)
        {
            // Perform payment check logic here
            return request.IsDiscountChecked; // Placeholder return value
        }
    }
}
