using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Coffees;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class DarkRoast :
    BeverageBase
{
    public DarkRoast()
    {
        Description = CoffeeData.DarkRoast.Description;
    }

    protected override decimal BaseCost => CoffeeData.DarkRoast.BaseCost;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
