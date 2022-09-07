using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Factories;

public static class BeverageFactory
{
    public static T Create<T>()
        where T : BeverageBase, new()
    {
        return new T();
    }

    public static T WithSteamedMilk<T>(this T beverage)
        where T : BeverageBase
    {
        beverage.HasSteamedMilk = true;
        beverage.Condiments.Add(CondimentData.SteamedMilk);

        return beverage;
    }

    public static T WithMocha<T>(this T beverage)
        where T : BeverageBase
    {
        beverage.HasMocha = true;
        beverage.Condiments.Add(CondimentData.Mocha);

        return beverage;
    }
}
