using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DarkRoastWithSteamedMilkAndMocha :
    DarkRoast
{
    public DarkRoastWithSteamedMilkAndMocha()
    {
        Description += $" with {CondimentData.SteamedMilk.Description} and {CondimentData.Mocha.Description}";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentData.SteamedMilk.Cost + CondimentData.Mocha.Cost;
    }
}
