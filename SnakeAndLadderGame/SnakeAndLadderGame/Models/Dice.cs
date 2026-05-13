namespace SnakeAndLadderGame.Models
{
    public class Dice
    {
        private static readonly Random random = new Random();

        public int Roll()
        {
            return random.Next(1, 7); // 1 inclusive, 7 exclusive → 1 to 6
        }
    }
}
