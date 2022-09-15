using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Pizzas;

public class CheesePizza :
    PizzaBase
{
    public CheesePizza(string style, IPizzaIngredientFactory ingredientFactory)
        : base(style, PizzaType.Cheese, ingredientFactory)
    {
    }
}
