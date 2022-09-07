using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

public abstract class BeverageBase :
    IBeverage
{
    protected BeverageBase()
    {
        Description = "Unknown beverage";
        Size = Size.Small;
    }

    public CoffeeData? CoffeeData { get; protected set; }

    public string Description { get; protected set; }

    public Size Size { get; set; }

    public abstract decimal CalculateCost(Size? size = null);
}
