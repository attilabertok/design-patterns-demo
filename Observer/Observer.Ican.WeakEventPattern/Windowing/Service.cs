using System;

namespace Observer.Ican.WeakEventPattern.Windowing;

public class Service
{
    public event EventHandler DoingSomethingInteresting;

    public void Work()
    {
        DoingSomethingInteresting?.Invoke(this, EventArgs.Empty);
    }
}
