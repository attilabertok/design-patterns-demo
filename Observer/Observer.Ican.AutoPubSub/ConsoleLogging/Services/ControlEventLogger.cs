using Observer.Ican.AutoPubSub.Infrastructure.Eventing;
using Observer.Ican.AutoPubSub.UserInterface.Controls;
using Observer.Ican.AutoPubSub.UserInterface.Controls.Base;
using Observer.Ican.AutoPubSub.UserInterface.Events;

namespace Observer.Ican.AutoPubSub.ConsoleLogging.Services;

public class ControlEventLogger :
    IHandle<ControlClickedEvent>,
    IHandle<ContentChangedEvent>
{
    public void Handle(object sender, ControlClickedEvent eventArgs)
    {
        var control = (ControlBase)sender;
        Console.WriteLine($"The {control.GetType().Name} called '{control.Name}' was clicked {eventArgs.ClickCount} times.");
    }

    public void Handle(object sender, ContentChangedEvent eventArgs)
    {
        var textBox = (TextBox)sender;
        Console.WriteLine($"The content in the {textBox.GetType().Name} called '{textBox.Name}' has changed.");
    }
}
