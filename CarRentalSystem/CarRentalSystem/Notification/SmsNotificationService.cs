using CarRentalSystem.Enums;
using CarRentalSystem.Models;

namespace CarRentalSystem.Notification
{
    public class SmsNotificationService : INotificationService
    {
        public NotificationChannel Channel => NotificationChannel.SMS;
        public void Notify(NotificationMessage message)
        {
            Console.WriteLine($"SMS sent: {message.Message}");
        }
    }
}
