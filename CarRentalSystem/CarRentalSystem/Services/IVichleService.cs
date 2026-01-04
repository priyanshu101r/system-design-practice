using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public interface IVichleService
    {
        void AddVichle(Vichle vichle);
        void RemoveVichle(string vichleId);
        bool IsVichleAvailableForBook(string vichleId);
        Vichle GetVichleById(string vichleId);
    }
}
