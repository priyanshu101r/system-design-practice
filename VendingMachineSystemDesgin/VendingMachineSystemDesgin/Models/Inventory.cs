namespace VendingMachineSystemDesgin.Models
{
    public class Inventory
    {
        public List<ProductSelf> Products = new List<ProductSelf>
        {
            new ProductSelf
            {
                Code = 1,
                Product = new Product
                {
                    productType = Enums.ProductType.PAPSIE,
                    Price = 30,
                    Quantity = 5
                }
            },
            new ProductSelf
            {
                Code = 2,
                Product = new Product
                {
                    productType = Enums.ProductType.JUICE,
                    Price = 15,
                    Quantity = 5
                }
            },
            new ProductSelf
            {
                Code = 3,
                Product = new Product
                {
                    productType = Enums.ProductType.WATER,
                    Price = 20,
                    Quantity = 5
                }
            }
        };

        public bool IsProductAvaliable(int productCode, int quantity)
        {
            return Products.Any(x => x.Code == productCode && x.Product.Quantity >= quantity);
        }
        public ProductSelf GetProductSelf(int productCode)
        {
            var productSelf = Products.FirstOrDefault(x => x.Code == productCode);
            if (productSelf != null)
            {
                return productSelf;
            }
            return new ProductSelf();
        }
        public void RemvoeProductFromInventroy(int productCode, int quantity)
        {
            var product = Products.Where(x => x.Code == productCode).FirstOrDefault();
            product.Product.Quantity = product.Product.Quantity - quantity;
        }
    }
}
