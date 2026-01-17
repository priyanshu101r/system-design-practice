using VendingMachineSystemDesgin.Models;
using VendingMachineSystemDesgin.Service;

namespace VendingMachineSystemDesgin.State
{
    public class PaymentInProgress : IVendingState
    {
        private VendingMachine VendingMachine { get; set; }
        public PaymentInProgress(VendingMachine vendingMachine)
        {
            this.VendingMachine = vendingMachine;
        }
        public Result InsertMoney(decimal amount)
        {
            VendingMachine.Balance += amount;
            if (VendingMachine.Balance >= VendingMachine.RequiredAmount)
            {
                VendingMachine.SetState(new DispensingProductState(VendingMachine));
                return Result.Success($"Payment Completed of {amount}. Current balance: {VendingMachine.Balance}");
            }
            return Result.Success($"remaning balance {VendingMachine.Balance - VendingMachine.RequiredAmount}");
        }

        public Result SelectProduct(int productCode, int quantity)
        {
            return Result.Failure("product can not change now");
        }

        public Result Cancel()
        {
            decimal refundAmount = VendingMachine.Balance;
            VendingMachine.Balance = 0;
            VendingMachine.SetState(new IdleState(VendingMachine));
            return Result.Success($"the amount has be refuned with {refundAmount}");
        }

        public Result DispenseProduct()
        {
            return Result.Success("InProgress");
        }
    }
}
