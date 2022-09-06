using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

public class Whip :
    CondimentDecoratorBase
{
    public Whip(IBeverage beverage)
        : base(beverage)
    {
        Description += CondimentData.Whip.Description;
    }

    public override decimal CalculateCost()
    {
        return Beverage.CalculateCost() + CondimentData.Whip.Cost;
    }
}
