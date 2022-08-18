namespace Observer.HeadFirst.Common.Infrastructure;

public static class RandomExtensions
{
    public static double NextDouble(this Random random, Range<double> range)
    {
        var rangeSize = range.Max - range.Min;
        var variance = random.NextDouble() * rangeSize;

        return range.Min + variance;
    }
}
