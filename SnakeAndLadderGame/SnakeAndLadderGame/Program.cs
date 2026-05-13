// See https://aka.ms/new-console-template for more information
using SnakeAndLadderGame.Services;

Console.WriteLine("Hello, World!");

Game game = new Game();
game.StartGame(game.board);