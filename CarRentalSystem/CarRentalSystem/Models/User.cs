namespace CarRentalSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool HasLicence { get; set; }
        public string Password { get; set; }
    }
}
