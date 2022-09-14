using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

namespace Factory.HeadFirst.Pizzeria.Naive.Stores;

public class PizzaStore
{
    private readonly string style;

    public PizzaStore(string style)
    {
        this.style = style;
    }

    /// <remarks>
    /// Whenever we want to add a new pizza style or type, we have to add the classes, and modify pizza creation code here
    /// </remarks>
    public PizzaBase OrderPizza(string type)
    {
        var pizza = style switch
        {
            PizzaStyle.Chicago => CreateChicagoStylePizza(type),
            PizzaStyle.NewYork => CreateNewYorkStylePizza(type),
            _ => throw new ArgumentOutOfRangeException(nameof(style), style, "Unknown pizza style")
        };

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    private static PizzaBase CreateNewYorkStylePizza(string type)
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

    private static PizzaBase CreateChicagoStylePizza(string type)
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
