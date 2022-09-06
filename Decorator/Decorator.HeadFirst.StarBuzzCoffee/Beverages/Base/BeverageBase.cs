namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

public abstract class BeverageBase :
    IBeverage
{
    protected BeverageBase()
    {
        Description = "Unknown beverage";
    }

    public string Description { get; protected set; }

    public abstract decimal CalculateCost();
}
