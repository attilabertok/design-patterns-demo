using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories.Interfaces;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories;

/// <remarks>
/// The Simple Factory can be an instance - mockable, replaceable.
/// </remarks>
public class PizzaFactory : IPizzaFactory
{
    private readonly string style;

    public PizzaFactory(string style)
    {
        this.style = style;
    }

    public PizzaBase CreatePizza(string type)
    {
        return style switch
        {
            PizzaStyle.Chicago => ChicagoStylePizzaFactory.CreateChicagoStylePizza(type),
            PizzaStyle.NewYork => NewYorkStylePizzaFactory.CreateNewYorkStylePizza(type),
            _ => throw new ArgumentOutOfRangeException(nameof(style), style, "Unknown pizza style")
        };
    }
}
