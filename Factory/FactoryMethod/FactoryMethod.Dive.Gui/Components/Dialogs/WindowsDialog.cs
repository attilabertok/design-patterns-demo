using FactoryMethod.Dive.Gui.Components.Buttons;
using FactoryMethod.Dive.Gui.Components.Buttons.Interfaces;
using FactoryMethod.Dive.Gui.Components.Dialogs.Base;

namespace FactoryMethod.Dive.Gui.Components.Dialogs;

public class WindowsDialog :
    DialogBase
{
    public WindowsDialog(string name)
        : base(name)
    {
    }

    public override IButton CreateButton()
    {
        Console.WriteLine($"Here is a windows dialog, called {Name}");
        return new WindowsButton();
    }
}
