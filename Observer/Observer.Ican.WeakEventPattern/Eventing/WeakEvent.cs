using System;

using Observer.Ican.WeakEventPattern.Eventing.Interfaces;
using Observer.Ican.WeakEventPattern.Infrastructure;
using Observer.Ican.WeakEventPattern.Windowing;

namespace Observer.Ican.WeakEventPattern.Eventing;

public class WeakEvent :
    IEventDemo
{
    private readonly Service service;
    private WeakEventWindow weakWindow;

    public WeakEvent(Service service)
    {
        this.service = service;
        Console.WriteLine("Creating weak event window...");
        weakWindow = new WeakEventWindow(this.service);
    }

    public void Demo()
    {
        Console.WriteLine("Starting service operation...");
        service.Work();
    }

    public void Cleanup()
    {
        Console.WriteLine("Setting weak event window to null...");
        var windowRef = weakWindow.Cleanup();
        weakWindow = null;
        GarbageCollector.Cleanup(windowRef);
        Console.WriteLine($"Weak event window is null? {weakWindow is null}");
    }
}
