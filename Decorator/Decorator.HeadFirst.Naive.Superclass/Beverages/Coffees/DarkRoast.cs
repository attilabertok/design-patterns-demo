using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class DarkRoast :
    BeverageBase
{
    private const string BaseDescription = "Most Excellent Dark Roast";

    public DarkRoast()
    {
        Description = BaseDescription;
    }

    protected override decimal BaseCost => 0.99m;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
