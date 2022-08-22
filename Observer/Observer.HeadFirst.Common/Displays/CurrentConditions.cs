using Observer.HeadFirst.Common.Displays.Interfaces;
using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Common.Displays;

public class CurrentConditions : IWeatherDisplay
{
    public void Update(WeatherChangeMessage message)
    {
        Console.WriteLine($"The current temperature is {message.Temperature:F1} °C, the humidity is {message.Humidity:F2}%.");
        Console.WriteLine();
    }
}
