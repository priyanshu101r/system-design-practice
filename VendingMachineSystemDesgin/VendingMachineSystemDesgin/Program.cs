// See https://aka.ms/new-console-template for more information
using VendingMachineSystemDesgin.Service;

Console.WriteLine("Hello, World!");


VendingMachine vendingMachine = new VendingMachine(new VendingMachineSystemDesgin.Models.Inventory());
Console.WriteLine(vendingMachine.SelectedProduct(1, 2));
Console.WriteLine(vendingMachine.InsertMoney(80));
//Console.WriteLine(vendingMachine.InsertMoney(50));
Console.WriteLine(vendingMachine.Dispense());

Console.WriteLine("\n--- Cancel flow ---\n");

Console.WriteLine(vendingMachine.SelectedProduct(3, 1));
Console.WriteLine(vendingMachine.InsertMoney(20));
Console.WriteLine(vendingMachine.Cancel());
Console.WriteLine(vendingMachine.Dispense());
