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
        Description += CondimentData.SteamedMilk.Description;
    }

    public override decimal CalculateCost()
    {
        return Beverage.CalculateCost() + CondimentData.SteamedMilk.Cost;
    }
}
