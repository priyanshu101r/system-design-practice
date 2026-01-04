using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class OlivesDecorator : PizzaDecorator
    {
        public OlivesDecorator(IPizza pizza) : base(pizza) { }

        public override string Description()
        {
            return _pizza.Description() + ", Olives";
        }

        public override double Cost()
        {
            return _pizza.Cost() + 30;
        }
    }


}
