using FactoryMethod.Dive.Gui.Components.Dialogs;
using FactoryMethod.Dive.Gui.Components.Dialogs.Base;
using FactoryMethod.Dive.Gui.Infrastructure;

namespace FactoryMethod.Dive.Gui.Factories
{
    public static class SimpleDialogFactory
    {
        public static DialogBase CreateDialog(OpSystem os, string name)
        {
            if (os == OpSystem.Windows)
            {
                return new WindowsDialog(name);
            }

            if (os == OpSystem.Web)
            {
                return new WebDialog(name);
            }

            throw new ArgumentOutOfRangeException(nameof(os), os, "Unknown operating system");
        }
    }
}
