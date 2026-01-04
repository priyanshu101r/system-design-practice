namespace StrategyPattern.Strategy
{
    public class NormalDrive : DriveStartegy
    {
        public void Drive()
        {
            Console.WriteLine("Normal drive strategy");
        }
    }

}
