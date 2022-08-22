using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.Common.WeatherStation;
using Observer.HeadFirst.SelfImplemented.Infrastructure;

namespace Observer.HeadFirst.SelfImplemented;

public class WeatherData :
    WeatherDataBase,
    ISubject
{
    private readonly List<IObserver> observers = new();

    public override void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(new WeatherChangeMessage(Temperature, Humidity, Pressure));
        }
    }
}
