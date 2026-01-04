namespace ChainOfResponsbilityPattern.Models
{
    public class OrderResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public OrderResponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
