using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class Espresso :
    BeverageBase
{
    public Espresso()
    {
        Description = CoffeeData.Espresso.Description;
    }

    protected override decimal BaseCost => CoffeeData.Espresso.BaseCost;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
