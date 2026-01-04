using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string Description()
        {
            return _pizza.Description() + ", Cheese";
        }

        public override double Cost()
        {
            return _pizza.Cost() + 40;
        }
    }
}
