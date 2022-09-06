using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DarkRoastWithMocha :
    DarkRoast
{
    public DarkRoastWithMocha()
    {
        Description += " with Mocha";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentCost.Mocha;
    }
}
