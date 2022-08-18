using Observer.HeadFirst.Common.Displays.Interfaces;

namespace Observer.HeadFirst.Common.Displays;

public class CurrentConditions : IWeatherDisplay
{
    public void Update(double temperature, double humidity, double pressure)
    {
        Console.WriteLine($"The current temperature is {temperature:F1} °C, the humidity is {humidity:F2}%.");
        Console.WriteLine();
    }
}
