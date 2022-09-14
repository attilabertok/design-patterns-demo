using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables;

public class Mushroom :
    VegetableBase
{
    public Mushroom()
        : base(Vegetable.Mushroom)
    {
    }
}
