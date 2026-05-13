using SnakeAndLadderGame.Models;

namespace SnakeAndLadderGame.Services
{
    public class Game
    {
        public Board board { get; set; }
        public Game()
        {
            InitializeGame();
        }
        public void InitializeGame()
        {
            board = CreateBoard(5, 5);
        }
        public Board CreateBoard(int numberOfSnake, int numberOfLadder)
        {
            Board board = new Board();
            board.TotalNumperOfCells = 100;
            List<Snake> snakes = new List<Snake>();
            List<Ladder> ladders = new List<Ladder>();

            for (int i = 0; i < numberOfSnake; i++)
            {
                Random random = new Random();

                int start = random.Next(2, board.TotalNumperOfCells);   // snake can't start at 1
                int end = random.Next(1, start);          // end must be less than start


                Snake snake = new Snake();
                snake.Start = start; // Example start position 
                snake.End = end;    // Example end position   

                snakes.Add(snake);
                // Logic to set snake start and end positions

            }
            for (int i = 0; i < numberOfLadder; i++)
            {
                Random random = new Random();
                int start = random.Next(1, board.TotalNumperOfCells - 1);
                int end = random.Next(start + 1, board.TotalNumperOfCells);
                Ladder ladder = new Ladder();
                ladder.Start = start; // Example start position 
                ladder.End = end;  // Example end position

                ladders.Add(ladder);
            }

            foreach (var snake in snakes)
            {
                board.jumps[snake.Start] = new Jump(snake.Start, snake.End);
            }
            foreach (var ladder in ladders)
            {
                board.jumps[ladder.Start] = new Jump(ladder.Start, ladder.End);
            }
            return board;

        }
        public Queue<Player> CreatePlayer()
        {
            Queue<Player> queue = new Queue<Player>();
            queue.Enqueue(new Player("Priyanshu"));
            queue.Enqueue(new Player("Mohit"));
            return queue;
        }
        public void StartGame(Board board)
        {

            var palyers = CreatePlayer();

            while (true)
            {
                Player currentPlayer = palyers.Dequeue();
                Console.WriteLine($"Current Player is {currentPlayer.Name}");
                Dice dice = new Dice();
                var value = dice.Roll();
                Console.WriteLine($"Dice Rolled Value is {value}");

                currentPlayer.CurrentPosition = currentPlayer.CurrentPosition + value;
                if (board.jumps.ContainsKey(currentPlayer.CurrentPosition))
                {
                    Console.WriteLine($"Player {currentPlayer.Name} encountered a jump at position {currentPlayer.CurrentPosition}");
                    var jump = board.jumps[currentPlayer.CurrentPosition];
                    if (jump.Start > jump.End)
                    {
                        Console.WriteLine($"It's a snake! Moving down from {jump.Start} to {jump.End}");
                    }
                    else
                    {
                        Console.WriteLine($"It's a ladder! Climbing up from {jump.Start} to {jump.End}");
                    }
                    currentPlayer.CurrentPosition = jump.End;
                    Console.WriteLine($"Player {currentPlayer.Name} moved to position {currentPlayer.CurrentPosition} due to jump");
                }
                if (currentPlayer.CurrentPosition >= board.TotalNumperOfCells)
                {
                    Console.WriteLine($"Player {currentPlayer.Name} has won the game!");
                    break;
                }
                palyers.Enqueue(currentPlayer);
            }
        }

    }
}
