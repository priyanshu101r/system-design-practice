using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public class InventroyCheckHandler : CheckOutHandler
    {
        public override OrderResponse HandleRequest(OrderRequest request)
        {
            if (!IsInvtoryIsVlaid(request))
            {
                return new OrderResponse(false, "inventory is not valid");
            }
            return _nextHandler.HandleRequest(request);
        }
        private bool IsInvtoryIsVlaid(OrderRequest request)
        {
            // Perform payment check logic here
            return request.IsInventoryChecked; // Placeholder return value
        }
    }
}
