using System.Collections.Immutable;

namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;

public sealed class Size
{
    private const string SmallValue = "Tall";
    private const string MediumValue = "Grande";
    private const string LargeValue = "Venti";

    private Size(string value)
    {
        Value = value;
    }

    public static Size Small { get; } = new(SmallValue);

    public static Size Medium { get; } = new(MediumValue);

    public static Size Large { get; } = new(LargeValue);

    public static ImmutableList<Size> Values { get; } = new List<Size>
    {
        Small,
        Medium,
        Large
    }.ToImmutableList();

    public string Value { get; }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Value;
    }
}
