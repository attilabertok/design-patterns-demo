using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Rx.Displays;

public class Forecast :
    Common.Displays.Forecast,
    IObserver<WeatherChangeMessage>
{
    public Forecast(IObservable<WeatherChangeMessage> dataSource)
    {
        dataSource.Subscribe(this);
    }

    public void OnCompleted()
    {
        // would be called when there are no more notifications
    }

    public void OnError(Exception error)
    {
        // would be called if an exception happens
    }

    public void OnNext(WeatherChangeMessage value)
    {
        Update(value);
    }
}