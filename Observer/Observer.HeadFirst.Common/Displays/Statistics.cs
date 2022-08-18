using Observer.HeadFirst.Common.Displays.Interfaces;

namespace Observer.HeadFirst.Common.Displays;

public class Statistics : IWeatherDisplay
{
    private readonly List<double> temperatureValues = new();
    private readonly List<double> humidityValues = new();
    private readonly List<double> pressureValues = new();

    public void Update(double temperature, double humidity, double pressure)
    {
        temperatureValues.Add(temperature);
        humidityValues.Add(humidity);
        pressureValues.Add((pressure / 100) + 29.7);

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
        Console.WriteLine($"All-time low: {values.Min().ToString(format)}");
        Console.WriteLine($"All-time high: {values.Max().ToString(format)}");
        Console.WriteLine($"Average: {values.Average().ToString(format)}");
    }
}
