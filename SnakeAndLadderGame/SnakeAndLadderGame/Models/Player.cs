namespace SnakeAndLadderGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int CurrentPosition { get; set; }
        public Player(string name)
        {
            Name = name;
            CurrentPosition = 0;
        }
    }
}
