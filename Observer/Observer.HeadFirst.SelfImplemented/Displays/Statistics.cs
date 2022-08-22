using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented.Displays;

public class Statistics :
    Common.Displays.Statistics,
    IObserver
{
    public Statistics(ISubject dataSource)
    {
        dataSource.Subscribe(this);
    }
}
