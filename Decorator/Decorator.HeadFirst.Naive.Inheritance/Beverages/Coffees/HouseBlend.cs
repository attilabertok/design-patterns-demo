using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Coffees;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    public HouseBlend()
    {
        Description = CoffeeData.HouseBlend.Description;
    }

    public override decimal CalculateCost()
    {
        return CoffeeData.HouseBlend.BaseCost;
    }
}
