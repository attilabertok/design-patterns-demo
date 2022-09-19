using FactoryMethod.Dive.Gui.Components.Interfaces;

namespace FactoryMethod.Dive.Gui.Components.Buttons.Interfaces;

public interface IButton :
    IComponent
{
    event EventHandler? OnClick;

    void EmulateClick();
}
