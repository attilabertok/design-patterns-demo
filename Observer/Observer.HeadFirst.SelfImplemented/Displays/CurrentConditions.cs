using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented.Displays;

public class CurrentConditions :
    Common.Displays.CurrentConditions,
    IObserver
{
    public CurrentConditions(ISubject dataSource)
    {
        dataSource.Subscribe(this);
    }
}
