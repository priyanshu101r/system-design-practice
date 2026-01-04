using ChainOfResponsbilityPattern.Models;

namespace ChainOfResponsbilityPattern.Handlers
{
    public abstract class CheckOutHandler
    {
        protected CheckOutHandler? _nextHandler;

        public void SetNextHandler(CheckOutHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract OrderResponse HandleRequest(OrderRequest request);
    }
}
