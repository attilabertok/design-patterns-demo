using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.SelfImplemented.Infrastructure;

public interface IObserver
{
    void Update(WeatherChangeMessage message);
}
