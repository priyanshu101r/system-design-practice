using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public class Vichle
    {
        DriveStartegy driveStartegy;
        public Vichle(DriveStartegy driveStartegy)
        {
            this.driveStartegy = driveStartegy;
        }

        public virtual void Drive()
        {
            this.driveStartegy.Drive();

        }
    }
}
