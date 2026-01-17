using VendingMachineSystemDesgin.Models;
using VendingMachineSystemDesgin.Service;

namespace VendingMachineSystemDesgin.State
{
    public class ProductSelectedState : IVendingState
    {
        private VendingMachine vendingMachine;

        public ProductSelectedState(VendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public Result InsertMoney(decimal amount)
        {
            vendingMachine.Balance += amount;
            if (vendingMachine.Balance >= vendingMachine.RequiredAmount)
            {
                vendingMachine.SetState(new DispensingProductState(vendingMachine));
            }
            else
            {
                vendingMachine.SetState(new PaymentInProgress(vendingMachine));
            }
            return Result.Success($"Transaction inprogress");
        }

        public Result Cancel()
        {
            decimal refundAmount = vendingMachine.Balance;
            return Result.Failure($"Transaction cancelled. Refunding {refundAmount}.");

        }

        public Result DispenseProduct()
        {

            return Result.Failure("Insufficient balance. Please insert more money.");
        }

        public Result SelectProduct(int productCode, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
