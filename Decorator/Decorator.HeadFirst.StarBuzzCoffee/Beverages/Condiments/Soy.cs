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
        Description += CondimentData.Soy.Description;
    }

    public override decimal CalculateCost()
    {
        return Beverage.CalculateCost() + CondimentData.Soy.Cost[Size];
    }
}
