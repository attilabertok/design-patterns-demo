using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DarkRoastWithSteamedMilk :
    DarkRoast
{
    public DarkRoastWithSteamedMilk()
    {
        Description += " with Steamed Milk";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentCost.SteamedMilk;
    }
}
