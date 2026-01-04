

using CarRentalSystem.ApplicationServices;
using CarRentalSystem.Models;
using CarRentalSystem.Notification;
using CarRentalSystem.PaymentStrategy;
using CarRentalSystem.PricingStrategy;
using CarRentalSystem.Services;

IUserService userService = new UserService();
var user = userService.GetUserById(001);

Console.WriteLine($"User Retrieved: {user.Name}, Email: {user.Email}");
IVichleService vichleService = new VichleService();
IBookingService bookingService = new BookingService(vichleService);
IPaymentStrategy paymentStrategy = new CardPayment();
IPricingStrategy pricingStrategy = new DailyPricingStrategy();
List<INotificationService> notificationServices = new List<INotificationService>()
{
    new EmailNotificationService(),
    new SmsNotificationService()
};
NotificationPolicy policy = new NotificationPolicy();

NotificationManager notificationManager = new NotificationManager(notificationServices, policy);

BookingApplicationService bookingappService = new BookingApplicationService(bookingService, pricingStrategy, paymentStrategy, notificationManager);
var bookingRequest = new Booking
{
    StoreId = "STORE_001",
    UserId = "USER_101",
    VichleNo = "UP14",

    BookingDate = DateTime.Today,
    ReturnDate = DateTime.Today.AddDays(2),

    IsOnDoorDelivery = true,
    DileveryAddress = "Ram Vihar, Loni, Ghaziabad",

    PickupTime = DateTime.Today.AddHours(10),
    ReturnTime = DateTime.Today.AddDays(2).AddHours(18)
};

bookingappService.BookVichle(bookingRequest);

