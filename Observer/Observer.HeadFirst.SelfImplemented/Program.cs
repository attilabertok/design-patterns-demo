using Observer.HeadFirst.SelfImplemented.Displays;
using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented
{
    public static class Program
    {
        public static void Main()
        {
            var weatherData = new WeatherData();
            var _ = new List<IObserver>
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
