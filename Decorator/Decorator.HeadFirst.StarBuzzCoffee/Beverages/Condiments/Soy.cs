using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

public class Soy :
    CondimentDecoratorBase
{
    public Soy(IBeverage beverage)
        : base(beverage)
    {
        CondimentData = CondimentData.Soy;
        Description += CondimentData.Description;
    }
}
