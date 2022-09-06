using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;

public abstract class CondimentDecoratorBase :
    IBeverage
{
    protected CondimentDecoratorBase(IBeverage beverage)
    {
        Beverage = beverage;
        Description = $"{beverage.Description} and ";
    }

    public string Description { get; protected set; }

    protected IBeverage Beverage { get; }

    public abstract decimal CalculateCost();
}
