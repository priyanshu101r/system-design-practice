using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class OffroadVichle : Vichle
    {
        public OffroadVichle() : base(new SportsDrive())
        {

        }

    }
}
