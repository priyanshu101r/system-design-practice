using CarRentalSystem.Enums;
using CarRentalSystem.Models;

namespace CarRentalSystem.Notification
{
    public interface INotificationService
    {
        NotificationChannel Channel { get; }
        public void Notify(NotificationMessage message);
    }
}
