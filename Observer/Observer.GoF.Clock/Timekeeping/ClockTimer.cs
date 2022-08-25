using Observer.GoF.Clock.Infrastructure;

namespace Observer.GoF.Clock.Timekeeping;

public class ClockTimer :
    SubjectBase
{
    public ClockTimer()
    {
        var _ = new Timer(Tick, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
    }

    public virtual int Hour { get; private set; }

    public virtual int Minute { get; private set; }

    public virtual int Second { get; private set; }

    public void Tick(object? _)
    {
        var now = DateTime.UtcNow;
        Hour = now.Hour;
        Minute = now.Minute;
        Second = now.Second;

        Notify();
    }
}
