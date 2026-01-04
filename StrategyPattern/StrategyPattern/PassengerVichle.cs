using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class PassengerVichle : Vichle
    {
        public PassengerVichle() : base(new NormalDrive())
        {

        }

    }
}
