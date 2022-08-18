using Observer.HeadFirst.Common.Displays.Interfaces;

namespace Observer.HeadFirst.Common.Displays;

// this is a new display, recently added
public class HeatIndex : IWeatherDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        var temperatureInFahrenheit = ((9 * temperature) / 5) + 32;
        var heatIndex = -42.379 + (2.04901523 * temperatureInFahrenheit)
                                + (10.14333127 * humidity)
                                - (0.22475541 * temperatureInFahrenheit * humidity)
                                - (0.00683783 * temperatureInFahrenheit * temperatureInFahrenheit)
                                - (0.05481717 * humidity * humidity)
                                + (0.00122874 * temperatureInFahrenheit * temperatureInFahrenheit * humidity)
                                + (0.00085282 * temperatureInFahrenheit * humidity * humidity)
                                - (0.00000199 * temperatureInFahrenheit * temperatureInFahrenheit * humidity * humidity);

        Console.WriteLine($"The current heat index is {heatIndex:F0}");
        Console.WriteLine();
    }
}
