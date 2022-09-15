using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Pizzas;

public class VeggiePizza :
    PizzaBase
{
    public VeggiePizza(string style, IPizzaIngredientFactory ingredientFactory)
        : base(style, PizzaType.Veggie, ingredientFactory)
    {
    }

    public override void Prepare()
    {
        Toppings = Toppings.Concat(IngredientFactory.CreateVegetables()).ToImmutableList();
        base.Prepare();
    }
}
