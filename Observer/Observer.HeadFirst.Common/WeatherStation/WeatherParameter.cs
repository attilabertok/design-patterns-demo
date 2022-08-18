using Observer.HeadFirst.Common.Infrastructure;

namespace Observer.HeadFirst.Common.WeatherStation;

public class WeatherParameter
{
    private readonly Random random;
    private readonly Range<double> range;
    private readonly Action<double> callback;

    private double changeCount;
    private Timer timer;

    public WeatherParameter(Random random, Range<double> range, Action<double> callback)
    {
        this.random = random;
        this.range = range;
        this.callback = callback;
        timer = new Timer(UpdateTemperature, null, TimeSpan.FromSeconds(random.Next(1, 5)), Timeout.InfiniteTimeSpan);
    }

    private void UpdateTemperature(object? state)
    {
        var newValue = random.NextDouble(range);
        callback?.Invoke(newValue);

        if (changeCount < SimulationData.GlobalChangeCount)
        {
            changeCount++;
            timer = new Timer(UpdateTemperature, null, TimeSpan.FromSeconds(random.Next(1, 5)), Timeout.InfiniteTimeSpan);
        }
    }
}
