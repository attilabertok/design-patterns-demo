using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.System.Displays;

namespace Observer.HeadFirst.System
{
    public static class Program
    {
        public static void Main()
        {
            var weatherData = new WeatherData();
            var _ = new List<IObserver<WeatherChangeMessage>>
            {
                new CurrentConditions(weatherData),
                new Forecast(weatherData),
                new HeatIndex(weatherData),
                new Statistics(weatherData)
            };

            Console.ReadLine();
        }
    }
}
