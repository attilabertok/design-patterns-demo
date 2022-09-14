using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.NewYork.Base;

public abstract class NewYorkStylePizzaBase :
    PizzaBase
{
    protected NewYorkStylePizzaBase(string name, ImmutableList<ITopping> toppings)
        : base($"{PizzaStyle.NewYork} style {name}", new ThinCrustDough(), new MarinaraSauce(), toppings.Append(new ReggianoCheese()).ToImmutableList())
    {
    }
}
