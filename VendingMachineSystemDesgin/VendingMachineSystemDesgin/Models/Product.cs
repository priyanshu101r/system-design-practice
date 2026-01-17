using VendingMachineSystemDesgin.Enums;

namespace VendingMachineSystemDesgin.Models
{
    public class Product
    {
        public ProductType productType { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
