using CarRentalSystem.Enums;

namespace CarRentalSystem.Notification
{
    public class NotificationPolicy
    {
        public List<NotificationChannel> GetChannels(NotificationType type)
        {



            switch (type)
            {
                case NotificationType.BookingCreated:
                    return new List<NotificationChannel> { NotificationChannel.Email, NotificationChannel.SMS };
                case NotificationType.PaymentFailed:
                    return new List<NotificationChannel> { NotificationChannel.Email };
                case NotificationType.BookingCancelled:
                    return new List<NotificationChannel> { NotificationChannel.Email, NotificationChannel.Push };
                default:
                    return new List<NotificationChannel>
                {
                    NotificationChannel.Email
                };
            }

        }
    }
}
