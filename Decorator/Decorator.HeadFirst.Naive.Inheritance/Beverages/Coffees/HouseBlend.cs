using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    public HouseBlend()
    {
        CoffeeData = CoffeeData.HouseBlend;
        Description = CoffeeData.Description;
    }

    public override decimal CalculateCost(Size? size = null)
    {
        size ??= Size;

        return CoffeeData?.BaseCost[size] ?? 0;
    }
}
