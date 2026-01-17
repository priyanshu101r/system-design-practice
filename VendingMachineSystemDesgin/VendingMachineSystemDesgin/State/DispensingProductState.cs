using VendingMachineSystemDesgin.Models;
using VendingMachineSystemDesgin.Service;

namespace VendingMachineSystemDesgin.State
{
    public class DispensingProductState : IVendingState
    {
        private VendingMachine VendingMachine { get; set; }
        public DispensingProductState(VendingMachine vendingMachine)
        {
            this.VendingMachine = vendingMachine;
        }
        public Result Cancel()
        {
            return Result.Failure("Despensing in progress");
        }

        public Result DispenseProduct()
        {
            VendingMachine.Inventory.RemvoeProductFromInventroy(VendingMachine.SelectProductCode, VendingMachine.SelectedQuantity);
            decimal changeAmount = VendingMachine.Balance - VendingMachine.RequiredAmount;
            VendingMachine.Balance = 0;
            VendingMachine.SetState(new IdleState(VendingMachine));
            return Result.Success($"Product dispensed successfully. Change returned: {changeAmount}");
        }

        public Result InsertMoney(decimal amount)
        {
            return Result.Failure("can not insert money at this stage, it's Dispensing");
        }

        public Result SelectProduct(int productCode, int quantity)
        {
            return Result.Failure("can not selett product at this stage, it's Dispensing");
        }
    }
}
