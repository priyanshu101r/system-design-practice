using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class SportsVichle : Vichle
    {
        public SportsVichle() : base(new SportsDrive())
        {

        }

    }
}
