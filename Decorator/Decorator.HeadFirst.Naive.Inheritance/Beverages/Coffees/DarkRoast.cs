using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class DarkRoast :
    BeverageBase
{
    private const decimal BaseCost = 0.99m;
    private const string BaseDescription = "Most Excellent Dark Roast";

    public DarkRoast()
    {
        Description = BaseDescription;
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
