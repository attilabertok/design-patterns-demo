using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DarkRoastWithSteamedMilkAndMocha :
    DarkRoast
{
    public DarkRoastWithSteamedMilkAndMocha()
    {
        Description += " with Steamed Milk and Mocha";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentCost.SteamedMilk + CondimentCost.Mocha;
    }
}
