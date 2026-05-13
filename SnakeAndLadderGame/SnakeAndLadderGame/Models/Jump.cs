namespace SnakeAndLadderGame.Models
{
    public class Jump
    {
        public int Start { get; }
        public int End { get; }

        public Jump(int start, int end)
        {
            Start = start;
            End = end;
        }

        public bool IsSnake => End < Start;
        public bool IsLadder => End > Start;
    }
}
