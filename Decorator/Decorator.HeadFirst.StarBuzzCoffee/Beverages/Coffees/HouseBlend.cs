using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    private const decimal BaseCost = 0.89m;
    private const string BaseDescription = "House Blend Coffee";

    public HouseBlend()
    {
        Description = BaseDescription;
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
