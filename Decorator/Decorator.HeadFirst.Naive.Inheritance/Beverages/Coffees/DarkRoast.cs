using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Coffees;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class DarkRoast :
    BeverageBase
{
    public DarkRoast()
    {
        Description = CoffeeData.DarkRoast.Description;
    }

    public override decimal CalculateCost()
    {
        return CoffeeData.DarkRoast.BaseCost;
    }
}
