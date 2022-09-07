using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class Espresso :
    BeverageBase
{
    public Espresso()
    {
        Description = CoffeeData.Espresso.Description;
    }

    public override decimal CalculateCost()
    {
        return CoffeeData.Espresso.BaseCost;
    }
}
