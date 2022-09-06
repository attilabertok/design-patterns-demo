using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages;

public class NullBeverage :
    BeverageBase
{
    public NullBeverage()
    {
        Description = "That's all, thanks!";
    }

    protected override decimal BaseCost => 0;

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
