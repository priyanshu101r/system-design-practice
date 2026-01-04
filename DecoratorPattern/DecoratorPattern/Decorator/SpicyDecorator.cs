using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class SpicyDecorator : PizzaDecorator
    {
        public SpicyDecorator(IPizza pizza) : base(pizza) { }

        public override string Description()
        {
            return _pizza.Description() + ", Spicy Sauce";
        }

        public override double Cost()
        {
            return _pizza.Cost() + 25;
        }
    }
}
