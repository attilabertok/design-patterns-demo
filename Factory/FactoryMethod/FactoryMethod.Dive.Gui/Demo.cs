using FactoryMethod.Dive.Gui.Factories;
using FactoryMethod.Dive.Gui.Infrastructure;
using FactoryMethod.Dive.Gui.Infrastructure.Interfaces;
using NSubstitute;

namespace FactoryMethod.Dive.Gui
{
    public static class Demo
    {
        public static void Web()
        {
            Console.WriteLine("===> running in a web environment <===");

            var webConfig = Substitute.For<IConfig>();
            webConfig.OpSystem.Returns(OpSystem.Web);

            var dialog = SimpleDialogFactory.CreateDialog(webConfig.OpSystem, "Web dialog");
            dialog.Render();
            dialog.EmulateClick();
        }

        public static void Windows()
        {
            Console.WriteLine("===> running in a windows environment <===");

            var windowsConfig = Substitute.For<IConfig>();
            windowsConfig.OpSystem.Returns(OpSystem.Windows);

            var dialog = SimpleDialogFactory.CreateDialog(windowsConfig.OpSystem, "Windows dialog");
            dialog.Render();
            dialog.EmulateClick();
        }
    }
}
