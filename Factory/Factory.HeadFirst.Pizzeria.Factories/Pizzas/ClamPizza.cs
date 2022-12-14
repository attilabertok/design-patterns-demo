using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Pizzas;

public class ClamPizza :
    PizzaBase
{
    public ClamPizza(string style, IPizzaIngredientFactory ingredientFactory)
        : base(style, PizzaType.Clam, ingredientFactory)
    {
    }

    public override void Prepare()
    {
        Toppings = Toppings.Append(IngredientFactory.CreateClams()).ToImmutableList();
        base.Prepare();
    }
}
