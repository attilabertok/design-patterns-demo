using Observer.Ican.AutoPubSub.Infrastructure.Eventing;

namespace Observer.Ican.AutoPubSub.UserInterface.Events;

public class ControlClickedEvent :
    IEvent
{
    public ControlClickedEvent(int clickCount)
    {
        ClickCount = clickCount;
    }

    public int ClickCount { get; }
}
