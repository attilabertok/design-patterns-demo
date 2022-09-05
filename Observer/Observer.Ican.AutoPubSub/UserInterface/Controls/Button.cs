using Observer.Ican.AutoPubSub.Infrastructure.Eventing;
using Observer.Ican.AutoPubSub.UserInterface.Controls.Base;
using Observer.Ican.AutoPubSub.UserInterface.Events;

namespace Observer.Ican.AutoPubSub.UserInterface.Controls;

public class Button :
    ControlBase,
    ISend<ControlClickedEvent>
{
    public event EventHandler<ControlClickedEvent>? Sender;

    public string? Caption { get; set; }

    public void EmitClicks(int clickCount)
    {
        Sender?.Invoke(this, new ControlClickedEvent(clickCount));
    }
}
