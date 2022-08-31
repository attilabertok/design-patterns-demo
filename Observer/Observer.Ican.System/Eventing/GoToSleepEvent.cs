using Observer.Ican.System.Eventing.Interfaces;
using Observer.Ican.System.People;

namespace Observer.Ican.System.Eventing;

public class GoToSleepEvent :
    IEvent
{
    public GoToSleepEvent(Person person, TimeOnly time)
    {
        Person = person;
        Time = time;
    }

    public Person Person { get; }

    public TimeOnly Time { get; }
}
