using FactoryMethod.Dive.Gui.Components.Buttons;
using FactoryMethod.Dive.Gui.Components.Buttons.Interfaces;
using FactoryMethod.Dive.Gui.Components.Dialogs.Base;

namespace FactoryMethod.Dive.Gui.Components.Dialogs;

public class WebDialog :
    DialogBase
{
    public WebDialog(string name)
        : base(name)
    {
    }

    public override IButton CreateButton()
    {
        Console.WriteLine($"Here is a web dialog, called {Name}");
        return new HtmlButton();
    }
}
