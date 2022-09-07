namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;

public class CostRange
{
    public CostRange(decimal min, decimal max)
    {
        Min = min;
        Max = max;
    }

    public decimal Min { get; }

    public decimal Max { get; }
}
