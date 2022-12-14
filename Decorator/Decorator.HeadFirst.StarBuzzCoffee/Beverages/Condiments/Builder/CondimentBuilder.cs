using System.Collections.Immutable;

using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Factories;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Builder;

public sealed class CondimentBuilder
{
    private CondimentBuilder(CondimentData data, Func<IBeverage, IBeverage> build)
    {
        Data = data;
        Build = build;
    }

    public static CondimentBuilder Nothing { get; } = new(CondimentData.Nothing, beverage => beverage);

    public static CondimentBuilder Soy { get; } = new(CondimentData.Soy, BeverageFactory.WithSoy);

    public static CondimentBuilder Mocha { get; } = new(CondimentData.Mocha, BeverageFactory.WithMocha);

    public static CondimentBuilder SteamedMilk { get; } = new(CondimentData.SteamedMilk, BeverageFactory.WithSteamedMilk);

    public static CondimentBuilder Whip { get; } = new(CondimentData.Whip, BeverageFactory.WithWhip);

    public static ImmutableList<CondimentBuilder> Values { get; } = new List<CondimentBuilder>
    {
        Nothing,
        Soy,
        Mocha,
        SteamedMilk,
        Whip
    }.ToImmutableList();

    public CondimentData Data { get; }

    public Func<IBeverage, IBeverage> Build { get; }
}
