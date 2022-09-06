using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class Decaf :
    BeverageBase
{
    private const string BaseDescription = "Coffee, but without the ooomph";

    public Decaf()
    {
        Description = BaseDescription;
    }

    protected override decimal BaseCost => 1.05m;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
