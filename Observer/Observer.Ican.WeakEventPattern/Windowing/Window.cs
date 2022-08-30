using System;

namespace Observer.Ican.WeakEventPattern.Windowing;

public class Window
{
    public Window(Service button)
    {
        button.DoingSomethingInteresting += (_, __) => HandleServiceEvent();
        Console.WriteLine("Window is created");
    }

    ~Window()
    {
        Console.WriteLine("Window is finalized");
    }

    public string WarningMessage { get; private set; } = string.Empty;

    public void Cleanup()
    {
        WarningMessage = "You should not see this: ";
    }

    private void HandleServiceEvent()
    {
        Console.WriteLine(WarningMessage + "Window was notified about the service doing something interesting");
    }
}
