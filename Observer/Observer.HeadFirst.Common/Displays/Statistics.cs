using Observer.HeadFirst.Common.Displays.Interfaces;
using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Common.Displays;

public class Statistics : IWeatherDisplay
{
    private readonly List<double> temperatureValues = new();
    private readonly List<double> humidityValues = new();
    private readonly List<double> pressureValues = new();

    public void Update(WeatherChangeMessage message)
    {
        if (Math.Abs(temperatureValues.LastOrDefault() - message.Temperature) > 0.1d)
        {
            temperatureValues.Add(message.Temperature);
        }

        if (Math.Abs(humidityValues.LastOrDefault() - message.Humidity) > 0.1d)
        {
            humidityValues.Add(message.Humidity);
        }

        if (Math.Abs(pressureValues.LastOrDefault() - (message.Pressure / 100) + 29.7) > 0.1d)
        {
            pressureValues.Add((message.Pressure / 100) + 29.7);
        }

        Console.WriteLine("==== Temperature statistics ====");
        DisplayData(temperatureValues, "F1");
        Console.WriteLine();

        Console.WriteLine("==== Humidity statistics ====");
        DisplayData(humidityValues, "F2");
        Console.WriteLine();

        Console.WriteLine("==== Pressure statistics ====");
        DisplayData(pressureValues, "F2");
        Console.WriteLine();
    }

    private static void DisplayData(IReadOnlyCollection<double> values, string format)
    {
        Console.WriteLine($"All-time low: {(values.Any() ? values.Min() : 0).ToString(format)}");
        Console.WriteLine($"All-time high: {(values.Any() ? values.Max() :0).ToString(format)}");
        Console.WriteLine($"Average: {(values.Any() ? values.Average() : 0).ToString(format)}");
    }
}
