using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

public class Mocha :
    CondimentDecoratorBase
{
    public Mocha(IBeverage beverage)
        : base(beverage)
    {
        CondimentData = CondimentData.Mocha;
        Description += CondimentData.Description;
    }
}
