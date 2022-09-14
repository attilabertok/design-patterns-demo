using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories;

/// <remarks>
/// The Simple Factory can be static - simpler, but not easy to mock / replace.
/// </remarks>
public static class NewYorkStylePizzaFactory
{
    public static PizzaBase CreateNewYorkStylePizza(string type)
    {
        return type switch
        {
            PizzaType.Cheese => new NewYorkStyleCheesePizza(),
            PizzaType.Pepperoni => new NewYorkStylePepperoniPizza(),
            PizzaType.Clam => new NewYorkStyleClamPizza(),
            PizzaType.Veggie => new NewYorkStyleVeggiePizza(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown pizza type"),
        };
    }
}
