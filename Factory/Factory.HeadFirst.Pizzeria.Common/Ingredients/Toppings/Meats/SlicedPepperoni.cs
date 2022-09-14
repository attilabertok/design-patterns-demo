using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats;

public class SlicedPepperoni :
    MeatBase
{
    public SlicedPepperoni()
        : base(Meat.SlicedPepperoni)
    {
    }
}
