using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    private const decimal BaseCost = 0.89m;
    private const string BaseDescription = "House blend coffee";

    public HouseBlend()
    {
        Description = BaseDescription;
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
