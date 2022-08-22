using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented.Displays;

public class Forecast :
    Common.Displays.Forecast,
    IObserver
{
    public Forecast(ISubject dataSource)
    {
        dataSource.Subscribe(this);
    }
}
