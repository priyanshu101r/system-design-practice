namespace SnakeAndLadderGame.Models
{
    public class Board
    {
        public Dictionary<int, Jump> jumps = new Dictionary<int, Jump>();
        public int TotalNumperOfCells { get; set; }
        public Snake snake { get; set; }
        public Ladder ladder { get; set; }
    }
}
