using VendingMachineSystemDesgin.Models;
using VendingMachineSystemDesgin.Service;

namespace VendingMachineSystemDesgin.State
{
    public class IdleState : IVendingState
    {
        private readonly VendingMachine vendingMachine;
        public IdleState(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }
        public Result SelectProduct(int productCode, int quantity)
        {
            if (vendingMachine.Inventory.IsProductAvaliable(productCode, quantity))
            {
                var productSelf = vendingMachine.Inventory.GetProductSelf(productCode);
                vendingMachine.SelectProductCode = productCode;
                vendingMachine.SelectedQuantity = quantity;
                vendingMachine.RequiredAmount = productSelf.Product.Price * quantity;
                vendingMachine.SetState(new ProductSelectedState(vendingMachine));
                return Result.Success("Product selected successfully");
            }
            return Result.Failure("Product is out of stock");
        }
        public Result Cancel()
        {
            return Result.Failure("Nothing to cancel");
        }

        public Result DispenseProduct()
        {
            return Result.Failure("payment pending");
        }

        public Result InsertMoney(decimal amount)
        {
            return Result.Failure("Select product first");
        }
    }
}
