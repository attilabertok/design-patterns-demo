using System.Collections.Immutable;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago.Base;

public abstract class ChicagoStylePizzaBase :
    PizzaBase
{
    protected ChicagoStylePizzaBase(string name, ImmutableList<ITopping> toppings)
        : base($"{PizzaStyle.Chicago} style {name}", new ThickCrustDough(), new PlumTomatoSauce(), toppings.Append(new MozzarellaCheese()).ToImmutableList())
    {
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices.");
    }
}
