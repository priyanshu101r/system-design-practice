using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public interface IUserService
    {
        public void RegisterUser(User user);
        public bool Login(string email, string password);
        User GetUserById(int userId);
    }
}
