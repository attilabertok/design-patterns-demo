using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago;

public class ChicagoStylePepperoniPizza :
    ChicagoStylePizzaBase
{
    public ChicagoStylePepperoniPizza()
        : base(
            PizzaType.Pepperoni,
            new List<ITopping> { new SlicedPepperoni() }.ToImmutableList())
    {
    }
}
