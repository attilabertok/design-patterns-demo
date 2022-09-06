using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class Espresso :
    BeverageBase
{
    private const string BaseDescription = "Espresso";

    public Espresso()
    {
        Description = BaseDescription;
    }

    protected override decimal BaseCost => 1.99m;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
