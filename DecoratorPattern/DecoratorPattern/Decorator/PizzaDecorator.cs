using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual double Cost()
        {
            return _pizza.Cost();
        }

        public virtual string Description()
        {
            return _pizza.Description();
        }
    }
}
