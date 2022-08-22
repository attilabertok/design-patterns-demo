using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Common.Displays.Interfaces;

public interface IWeatherDisplay
{
    void Update(WeatherChangeMessage message);
}
