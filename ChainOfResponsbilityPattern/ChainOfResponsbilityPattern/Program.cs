// See https://aka.ms/new-console-template for more information
using ChainOfResponsbilityPattern.Handlers;

Console.WriteLine("Hello, World!");

var orderRequest = new ChainOfResponsbilityPattern.Models.OrderRequest
{
    IsAuthChecked = true,
    IsInventoryChecked = true,
    IsDiscountChecked = false,
    IsPaymentDoneChecked = true
};


var placeOrderHandler = new PlacedOrderHandler();
var authHandler = new AuthCheckHandler();
var inventoryHandler = new InventroyCheckHandler();
var discountHandler = new DiscuountCheckHandler();
var paymentHandler = new PyamentCheckHandler();

authHandler.SetNextHandler(inventoryHandler);
inventoryHandler.SetNextHandler(discountHandler);
discountHandler.SetNextHandler(paymentHandler);
paymentHandler.SetNextHandler(placeOrderHandler);

var response = authHandler.HandleRequest(orderRequest);
Console.WriteLine(response.Message);

