using Observer.Ican.System.Eventing;
using Observer.Ican.System.Eventing.Interfaces;

namespace Observer.Ican.System.SleepDiary;

public class SleepLogger :
    IObserver<IEvent>
{
    public void OnCompleted()
    {
    }

    public void OnError(Exception error)
    {
    }

    public void OnNext(IEvent value)
    {
        if (value is GoToSleepEvent sleepEvent)
        {
            Console.WriteLine($"{sleepEvent.Person.Name} is going to sleep at {sleepEvent.Time}");
        }
    }
}
