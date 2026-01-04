// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

Console.WriteLine("Hello, World!");

IPizza pizza = new PlainPizza();

pizza = new CheeseDecorator(pizza);
pizza = new OlivesDecorator(pizza);
pizza = new SpicyDecorator(pizza);

Console.WriteLine(pizza.Description());
Console.WriteLine($"Total Cost: ₹{pizza.Cost()}");
