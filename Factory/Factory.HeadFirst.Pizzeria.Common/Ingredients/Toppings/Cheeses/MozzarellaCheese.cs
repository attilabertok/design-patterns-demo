using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses;

public class MozzarellaCheese :
    CheeseBase
{
    public MozzarellaCheese()
        : base(Cheese.Mozzarella)
    {
    }
}
