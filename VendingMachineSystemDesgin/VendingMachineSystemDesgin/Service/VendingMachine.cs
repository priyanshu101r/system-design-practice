using VendingMachineSystemDesgin.Models;
using VendingMachineSystemDesgin.State;

namespace VendingMachineSystemDesgin.Service
{
    public class VendingMachine
    {
        public IVendingState State { get; set; }
        public Inventory Inventory { get; set; }
        public decimal Balance { get; set; }
        public decimal RequiredAmount { get; set; }
        public int SelectProductCode { get; set; }
        public int SelectedQuantity { get; set; }
        public VendingMachine(Inventory inventory)
        {
            this.Inventory = inventory;
            this.State = new IdleState(this);
        }
        public void SetState(IVendingState state)
        {
            this.State = state;
        }
        public Result SelectedProduct(int productCode, int quantity)
        {
            return this.State.SelectProduct(productCode, quantity);
        }
        public Result InsertMoney(decimal amount)
        {
            return this.State.InsertMoney(amount);
        }
        public Result Cancel()
        {
            return this.State.Cancel();
        }
        public Result Dispense() => State.DispenseProduct();

    }
}
