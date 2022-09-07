using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

public class SteamedMilk :
    CondimentDecoratorBase
{
    public SteamedMilk(IBeverage beverage)
        : base(beverage)
    {
        CondimentData = CondimentData.SteamedMilk;
        Description += CondimentData.Description;
    }
}
