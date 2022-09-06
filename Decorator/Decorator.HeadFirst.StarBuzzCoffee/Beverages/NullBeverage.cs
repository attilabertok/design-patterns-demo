using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages;

public class NullBeverage :
    BeverageBase
{
    private const decimal BaseCost = 0;

    public NullBeverage()
    {
        Description = "That's all, thanks!";
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
