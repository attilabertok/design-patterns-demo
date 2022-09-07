using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

public class Whip :
    CondimentDecoratorBase
{
    public Whip(IBeverage beverage)
        : base(beverage)
    {
        CondimentData = CondimentData.Whip;
        Description += CondimentData.Description;
    }
}
