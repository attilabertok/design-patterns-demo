using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented.Displays;

public class HeatIndex :
    Common.Displays.HeatIndex,
    IObserver
{
    public HeatIndex(ISubject dataSource)
    {
        dataSource.Subscribe(this);
    }
}
