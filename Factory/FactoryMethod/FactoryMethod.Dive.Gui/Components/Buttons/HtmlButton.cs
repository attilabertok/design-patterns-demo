using FactoryMethod.Dive.Gui.Components.Buttons.Interfaces;

namespace FactoryMethod.Dive.Gui.Components.Buttons;

public class HtmlButton :
    IButton
{
    public event EventHandler? OnClick;

    public void EmulateClick()
    {
        OnClick?.Invoke(this, EventArgs.Empty);
    }

    public void Render()
    {
        Console.WriteLine("This here is a html button");
    }
}
