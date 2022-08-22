using Observer.HeadFirst.Common.Displays.Interfaces;
using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Common.Displays;

// this is a new display, recently added
public class HeatIndex : IWeatherDisplay
{
    public void Update(WeatherChangeMessage message)
    {
        var temperatureInFahrenheit = ((9 * message.Temperature) / 5) + 32;
        var heatIndex = -42.379 + (2.04901523 * temperatureInFahrenheit)
                                + (10.14333127 * message.Humidity)
                                - (0.22475541 * temperatureInFahrenheit * message.Humidity)
                                - (0.00683783 * temperatureInFahrenheit * temperatureInFahrenheit)
                                - (0.05481717 * message.Humidity * message.Humidity)
                                + (0.00122874 * temperatureInFahrenheit * temperatureInFahrenheit * message.Humidity)
                                + (0.00085282 * temperatureInFahrenheit * message.Humidity * message.Humidity)
                                - (0.00000199 * temperatureInFahrenheit * temperatureInFahrenheit * message.Humidity * message.Humidity);

        Console.WriteLine($"The current heat index is {heatIndex:F0}");
        Console.WriteLine();
    }
}
