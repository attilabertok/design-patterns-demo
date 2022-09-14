using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork;

public class NewYorkStyleVeggiePizza :
    NewYorkStylePizzaBase
{
    public NewYorkStyleVeggiePizza()
        : base(
            PizzaType.Veggie,
            new List<ITopping> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() }.ToImmutableList())
    {
    }
}
