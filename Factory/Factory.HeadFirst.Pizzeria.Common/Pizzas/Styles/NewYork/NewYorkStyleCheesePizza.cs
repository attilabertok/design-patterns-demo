using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

public class NewYorkStyleCheesePizza :
    NewYorkStylePizzaBase
{
    public NewYorkStyleCheesePizza()
        : base(
            PizzaType.Cheese,
            ImmutableList<ITopping>.Empty)
    {
    }
}
