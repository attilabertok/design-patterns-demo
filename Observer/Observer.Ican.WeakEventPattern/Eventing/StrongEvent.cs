using System;

using Observer.Ican.WeakEventPattern.Eventing.Interfaces;
using Observer.Ican.WeakEventPattern.Infrastructure;
using Observer.Ican.WeakEventPattern.Windowing;

namespace Observer.Ican.WeakEventPattern.Eventing;

public class StrongEvent :
    IEventDemo
{
    private readonly Service service;
    private Window window;

    public StrongEvent(Service service)
    {
        this.service = service;
        Console.WriteLine("Creating window...");
        window = new Window(service);
    }

    public void Demo()
    {
        Console.WriteLine("Starting service operation...");
        service?.Work();
    }

    public void Cleanup()
    {
        Console.WriteLine("Setting window to null...");
        window.Cleanup();
        window = null;
        GarbageCollector.Cleanup();
        Console.WriteLine($"Window is null? {window is null}");
    }
}
