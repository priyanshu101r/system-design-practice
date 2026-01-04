using CarRentalSystem.Enums;
using CarRentalSystem.Models;

namespace CarRentalSystem.Notification
{
    public class EmailNotificationService : INotificationService
    {
        public NotificationChannel Channel => NotificationChannel.Email;

        public void Notify(NotificationMessage message)
        {
            Console.WriteLine($"Email sent: {message.Message}");
        }
    }
}
