using System;
using System.Windows;

namespace Observer.Ican.WeakEventPattern.Windowing;

public class WeakEventWindow
{
    public WeakEventWindow(Service button)
    {
        WeakEventManager<Service, EventArgs>
            .AddHandler(button, nameof(Service.DoingSomethingInteresting), (_, __) => HandleServiceEvent());
        Console.WriteLine("Weak event window is created");
    }

    ~WeakEventWindow()
    {
        Console.WriteLine("Weak event window is finalized");
    }

    public string WarningMessage { get; private set; } = string.Empty;

    public WeakReference Cleanup()
    {
        WarningMessage = "You should not see this: ";

        return new WeakReference(this);
    }

    private void HandleServiceEvent()
    {
        Console.WriteLine(WarningMessage + "Weak event window was notified about the service doing something interesting");
    }
}
