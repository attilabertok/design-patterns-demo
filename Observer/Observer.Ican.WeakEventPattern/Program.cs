using System;

using Observer.Ican.WeakEventPattern.Eventing;
using Observer.Ican.WeakEventPattern.Windowing;

namespace Observer.Ican.WeakEventPattern;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Creating service...");
        var service = new Service();
        var strongEvent = new StrongEvent(service);
        strongEvent.Demo();
        strongEvent.Cleanup();

        Console.WriteLine();

        var weakEvent = new WeakEvent(service);
        weakEvent.Demo();
        weakEvent.Cleanup();

        Console.WriteLine();
        Console.WriteLine("Subscriber windows are set to null, GC ran, subscriptions should not be alive at this point...");
        service.Work();

        Console.ReadLine();
    }
}
