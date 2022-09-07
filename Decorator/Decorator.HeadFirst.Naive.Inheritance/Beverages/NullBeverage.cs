using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class NullBeverage :
    BeverageBase
{
    public NullBeverage()
    {
        Description = "That's all, thanks!";
    }

    public override decimal CalculateCost(Size? size = null)
    {
        return 0;
    }
}
