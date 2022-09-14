using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories;

/// <remarks>
/// The Simple Factory can be static - simpler, but not easy to mock / replace.
/// </remarks>
public static class ChicagoStylePizzaFactory
{
    public static PizzaBase CreateChicagoStylePizza(string type)
    {
        return type switch
        {
            PizzaType.Cheese => new ChicagoStyleCheesePizza(),
            PizzaType.Pepperoni => new ChicagoStylePepperoniPizza(),
            PizzaType.Clam => new ChicagoStyleClamPizza(),
            PizzaType.Veggie => new ChicagoStyleVeggiePizza(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown pizza type"),
        };
    }
}
