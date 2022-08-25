using Observer.GoF.Clock.Infrastructure;

namespace Observer.GoF.Clock.Timekeeping.Clocks;

public class DigitalClock :
    IObserver
{
    private readonly ClockTimer timer;

    public DigitalClock(ClockTimer timer)
    {
        this.timer = timer;
        timer.Attach(this);
    }

    public void Update(ISubject changedSubject)
    {
        Console.WriteLine($"{timer.Hour}:{timer.Minute}:{timer.Second}");
    }
}
