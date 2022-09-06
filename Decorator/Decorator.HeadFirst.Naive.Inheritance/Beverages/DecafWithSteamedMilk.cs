using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class DecafWithSteamedMilk :
    Decaf
{
    public DecafWithSteamedMilk()
    {
        Description += " with Steamed Milk";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentCost.SteamedMilk;
    }
}
