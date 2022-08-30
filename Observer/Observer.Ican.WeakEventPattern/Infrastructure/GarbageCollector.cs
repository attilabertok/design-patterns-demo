using System;

namespace Observer.Ican.WeakEventPattern.Infrastructure;

public static class GarbageCollector
{
    public static void Cleanup(WeakReference reference)
    {
        Console.WriteLine("Starting GC...");
        while (reference?.IsAlive ?? false)
        {
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        Console.WriteLine("GC is done");
    }

    public static void Cleanup()
    {
        Console.WriteLine("Starting GC...");
        GC.Collect();
        GC.WaitForFullGCComplete();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        Console.WriteLine("GC is done");
    }
}
