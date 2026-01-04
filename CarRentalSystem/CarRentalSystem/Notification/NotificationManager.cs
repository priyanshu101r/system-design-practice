using CarRentalSystem.Models;

namespace CarRentalSystem.Notification
{
    public class NotificationManager
    {
        public readonly IEnumerable<INotificationService> _notifications;
        public readonly NotificationPolicy notificationPolicy;
        public NotificationManager(IEnumerable<INotificationService> notifications, NotificationPolicy notificationPolicy)
        {
            _notifications = notifications;
            this.notificationPolicy = notificationPolicy;
        }
        public void NotifyAll(NotificationMessage message)
        {
            var channels = this.notificationPolicy.GetChannels(message.Type);
            foreach (var notification in _notifications)
            {
                if (channels.Contains(notification.Channel))
                    notification.Notify(message);
            }
        }
    }
}
