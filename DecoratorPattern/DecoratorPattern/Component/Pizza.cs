namespace DecoratorPattern.Component
{
    public class PlainPizza : IPizza
    {
        public double Cost()
        {
            return 5.00;
        }

        public string Description()
        {
            return "Basic Pizza";
        }
    }

}
