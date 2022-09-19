using FactoryMethod.Dive.Gui.Components.Buttons.Interfaces;
using FactoryMethod.Dive.Gui.Components.Interfaces;

namespace FactoryMethod.Dive.Gui.Components.Dialogs.Base;

public abstract class DialogBase :
    IComponent
{
    private IButton? okButton;

    protected DialogBase(string name)
    {
        Name = name;
    }

    protected string Name { get; }

    public abstract IButton CreateButton();

    public void Render()
    {
        okButton = CreateButton();
        okButton.OnClick += (_, _) => CloseDialog();
        okButton.Render();
    }

    public void CloseDialog()
    {
        Console.WriteLine($"The dialog '{Name}' is closed");
    }

    public void EmulateClick()
    {
        okButton?.EmulateClick();
    }
}
