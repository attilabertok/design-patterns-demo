using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    private const string BaseDescription = "House blend coffee";

    public HouseBlend()
    {
        Description = BaseDescription;
    }

    protected override decimal BaseCost => 0.89m;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
