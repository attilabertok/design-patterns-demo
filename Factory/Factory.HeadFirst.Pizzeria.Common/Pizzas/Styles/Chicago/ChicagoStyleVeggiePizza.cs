using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago;

public class ChicagoStyleVeggiePizza :
    ChicagoStylePizzaBase
{
    public ChicagoStyleVeggiePizza()
        : base(
            PizzaType.Veggie,
            new List<ITopping> { new BlackOlives(), new Spinach(), new SlicedPepperoni(), new Eggplant() }.ToImmutableList())
    {
    }
}
