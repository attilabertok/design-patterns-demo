using Observer.GoF.Clock.Infrastructure;

namespace Observer.GoF.Clock.Timekeeping.Clocks;

public class AnalogueClock :
    IObserver
{
    private readonly ClockTimer timer;

    public AnalogueClock(ClockTimer timer)
    {
        this.timer = timer;
        timer.Attach(this);
    }

    public void Update(ISubject changedSubject)
    {
        if (timer != changedSubject)
        {
            return;
        }

        var hour = timer.Hour % 12;

        var display = hour switch
        {
            0 => timer.Hour == 0 ? "⓪" : "⑫",
            1 => "①",
            2 => "②",
            3 => "③",
            4 => "④",
            5 => "⑤",
            6 => "⑥",
            7 => "⑦",
            8 => "⑧",
            9 => "⑨",
            10 => "⑩",
            11 => "⑪",
            _ => string.Empty
        };

        Console.WriteLine(display);
    }
}
