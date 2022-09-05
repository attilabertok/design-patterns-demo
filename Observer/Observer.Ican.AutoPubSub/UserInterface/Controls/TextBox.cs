using Observer.Ican.AutoPubSub.Infrastructure.Eventing;
using Observer.Ican.AutoPubSub.UserInterface.Controls.Base;
using Observer.Ican.AutoPubSub.UserInterface.Events;

namespace Observer.Ican.AutoPubSub.UserInterface.Controls;

public class TextBox :
    ControlBase,
    ISend<ControlClickedEvent>,
    ISend<ContentChangedEvent>
{
    private EventHandler<ControlClickedEvent>? clickedHandler;
    private EventHandler<ContentChangedEvent>? contentChangedHandler;

    event EventHandler<ControlClickedEvent>? ISend<ControlClickedEvent>.Sender
    {
        add => clickedHandler += value;
        remove => clickedHandler -= value;
    }

    event EventHandler<ContentChangedEvent>? ISend<ContentChangedEvent>.Sender
    {
        add => contentChangedHandler += value;
        remove => contentChangedHandler -= value;
    }

    public string? Content { get; set; }

    public void EmitClicks(int clickCount)
    {
        clickedHandler?.Invoke(this, new ControlClickedEvent(clickCount));
    }

    public void EmitContentChanged()
    {
        contentChangedHandler?.Invoke(this, new ContentChangedEvent());
    }
}
