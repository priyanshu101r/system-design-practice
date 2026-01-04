namespace ChainOfResponsbilityPattern.Models
{
    public class OrderRequest
    {
        public bool IsAuthChecked { get; set; }
        public bool IsInventoryChecked { get; set; }
        public bool IsDiscountChecked { get; set; }
        public bool IsPaymentDoneChecked { get; set; }

    }
}
