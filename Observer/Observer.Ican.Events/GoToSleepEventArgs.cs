namespace Observer.Ican.Events;

public class GoToSleepEventArgs :
    EventArgs
{
    public GoToSleepEventArgs(TimeOnly time)
    {
        Time = time;
    }

    public TimeOnly Time { get; }
}
