using CarRentalSystem.Enums;

namespace CarRentalSystem.Models
{
    public class NotificationMessage
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public NotificationType Type { get; set; }
    }
}
