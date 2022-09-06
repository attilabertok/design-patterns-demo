using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.Naive.Inheritance.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class EspressoWithSteamedMilk :
    Espresso
{
    public EspressoWithSteamedMilk()
    {
        Description += " with Steamed Milk";
    }

    public override decimal CalculateCost()
    {
        return base.CalculateCost() + CondimentCost.SteamedMilk;
    }
}
