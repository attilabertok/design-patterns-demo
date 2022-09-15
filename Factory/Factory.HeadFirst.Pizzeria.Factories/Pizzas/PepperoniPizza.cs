using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Pizzas;

public class PepperoniPizza :
    PizzaBase
{
    public PepperoniPizza(string style, IPizzaIngredientFactory ingredientFactory)
        : base(style, PizzaType.Pepperoni, ingredientFactory)
    {
    }

    public override void Prepare()
    {
        Toppings = Toppings.Append(IngredientFactory.CreatePepperoni()).ToImmutableList();
        base.Prepare();
    }
}
