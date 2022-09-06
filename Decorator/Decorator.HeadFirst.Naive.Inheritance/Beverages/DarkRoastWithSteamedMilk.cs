using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DarkRoastWithSteamedMilk :
    DarkRoast
{
    public DarkRoastWithSteamedMilk()
    {
        Description += $" with {CondimentData.SteamedMilk.Description}";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentData.SteamedMilk.Cost;
    }
}
