using Observer.HeadFirst.Common.Messages;

namespace Observer.HeadFirst.Rx.Displays;

public class Statistics :
    Common.Displays.Statistics,
    IObserver<WeatherChangeMessage>
{
    public Statistics(IObservable<WeatherChangeMessage> dataSource)
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
