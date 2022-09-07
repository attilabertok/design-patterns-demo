using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class HouseBlendWithSteamedMilk :
    HouseBlend
{
    public HouseBlendWithSteamedMilk()
    {
        Description += $" with {CondimentData.SteamedMilk.Description}";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentData.SteamedMilk.Cost;
    }
}
