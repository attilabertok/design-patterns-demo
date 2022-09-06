namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

public abstract class BeverageBase
{
    protected BeverageBase()
    {
        Description = "Unknown beverage";
    }

    public string Description { get; protected set; }

    public abstract decimal CalculateCost();
}
