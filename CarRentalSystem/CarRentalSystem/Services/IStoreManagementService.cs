using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public interface IStoreManagementService
    {
        List<Store> GetAllStore();
        Store GetStoreById(int storeId);
        void AddVichleToStore(int storeId, Vichle vichle);
    }
}
