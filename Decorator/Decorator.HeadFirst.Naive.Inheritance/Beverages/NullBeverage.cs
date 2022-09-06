using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class NullBeverage :
    BeverageBase
{
    public NullBeverage()
    {
        Description = "That's all, thanks!";
    }

    public override decimal CalculateCost()
    {
        return 0;
    }
}
