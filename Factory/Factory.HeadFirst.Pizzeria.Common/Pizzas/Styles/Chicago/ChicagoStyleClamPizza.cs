using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago;

public class ChicagoStyleClamPizza :
    ChicagoStylePizzaBase
{
    public ChicagoStyleClamPizza()
        : base(
            PizzaType.Clam,
            new List<ITopping> { new FrozenClams() }.ToImmutableList())
    {
    }
}
