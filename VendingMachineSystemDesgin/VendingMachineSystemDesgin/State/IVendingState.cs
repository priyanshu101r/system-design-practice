using VendingMachineSystemDesgin.Models;

namespace VendingMachineSystemDesgin.State
{
    public interface IVendingState
    {
        Result SelectProduct(int productCode, int quantity);
        Result InsertMoney(decimal amount);
        Result Cancel();
        Result DispenseProduct();
    }
}
