using Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages;

public class EspressoWithSteamedMilk :
    Espresso
{
    public EspressoWithSteamedMilk()
    {
        Condiments.Add(CondimentData.SteamedMilk);
        foreach (var condiment in Condiments)
        {
            Description += $" with {condiment.Description}";
        }
    }

    public override decimal CalculateCost(Size? size = null)
    {
        size ??= Size;
        var baseCost = base.CalculateCost(size);

        return baseCost + Condiments.Sum(condiment => condiment.Cost[size]);
    }
}
