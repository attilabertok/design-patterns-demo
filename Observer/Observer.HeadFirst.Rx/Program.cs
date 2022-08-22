using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.Rx.Displays;

namespace Observer.HeadFirst.Rx
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
