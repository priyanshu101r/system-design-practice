using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public class UserService : IUserService
    {
        public readonly List<User> _users = new List<User>()
            {
                new User{ UserId =001,Name="Priyanshu", Address="Ram vihar Loni", Email="Priyanshu101r@gmail.com", HasLicence=true , Password ="Priya@1998"},
                new User{ UserId =002,Name="Anikesh", Address="Delhi", Email="Anikesh101r@gmail.com", HasLicence=true, Password="Priya@1998" }
            };

        public void RegisterUser(User user)
        {

        }
        public bool Login(string email, string password)
        {
            var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return user != null;
        }
        public User GetUserById(int userId)
        {
            return _users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
