using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class Espresso :
    BeverageBase
{
    public Espresso()
    {
        CoffeeData = CoffeeData.Espresso;
        Description = CoffeeData.Description;
    }

    public override decimal CalculateCost(Size? size = null)
    {
        size ??= Size;

        return CoffeeData!.BaseCost[size] + base.CalculateCost(size);
    }
}
