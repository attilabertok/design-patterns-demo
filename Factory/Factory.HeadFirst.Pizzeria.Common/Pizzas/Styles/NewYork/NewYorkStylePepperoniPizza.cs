using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

public class NewYorkStylePepperoniPizza :
    NewYorkStylePizzaBase
{
    public NewYorkStylePepperoniPizza()
        : base(
            PizzaType.Pepperoni,
            new List<ITopping> { new SlicedPepperoni() }.ToImmutableList())
    {
    }
}
