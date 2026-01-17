// See https://aka.ms/new-console-template for more information
using ParkingSpotDesign.Gate;
using ParkingSpotDesign.Modal;
using ParkingSpotDesign.Payment;
using ParkingSpotDesign.Price;
using ParkingSpotDesign.RateProvider;
using ParkingSpotDesign.Repository;
using ParkingSpotDesign.Service;
using ParkingSpotDesign.Strategy;

Console.WriteLine("Hello, World!");
IParkingSpotRepository parkingSpotRepository = new InMemoryParkingSpotRepository();
IParkingSpotManager spotManager = new ParkingSpotManager(parkingSpotRepository);
Vichle vichle = new TwoWheeler("UP14");

EntranceGate entergate = new EntranceGate(spotManager);
Ticket parkingticket = entergate.Enter(vichle);

// here customer want to exit the vichle..
IPricingRateProvider pricingRateProvider = new DefaultPricingRateProvider();
IPaymentStrategy paymentStrategy = new UPIPayment();
IPricingStrategy pricingStrategy = new HourlyPricing(pricingRateProvider);
var spots = parkingSpotRepository.GetALL();
var spot = spots.Where(s => s.SpotId == parkingticket.ParkingSpotId).FirstOrDefault();
ExistGate existGate = new ExistGate(pricingStrategy, paymentStrategy);
existGate.ProcessExit(parkingticket, spot);



