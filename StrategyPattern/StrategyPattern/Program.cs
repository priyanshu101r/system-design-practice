// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Hello, World!");

//Startgy disgin pattern
Vichle vichle = new PassengerVichle();
vichle.Drive();
Vichle offroadvaiche = new OffroadVichle();
offroadvaiche.Drive();

Vichle sportsvichle = new SportsVichle();
sportsvichle.Drive();