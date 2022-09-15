using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

public class NewYorkStyleClamPizza :
    NewYorkStylePizzaBase
{
    public NewYorkStyleClamPizza()
        : base(
            PizzaType.Clam,
            new List<ITopping> { new FreshClams() }.ToImmutableList())
    {
    }
}
