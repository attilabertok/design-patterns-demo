using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.Common.WeatherStation;
using Observer.HeadFirst.System.Infrastructure;

namespace Observer.HeadFirst.System;

public class WeatherData :
    WeatherDataBase,
    IObservable<WeatherChangeMessage>
{
    private readonly List<IObserver<WeatherChangeMessage>> observers = new();

    public override void MeasurementsChanged()
    {
        foreach (var observer in observers)
        {
            observer.OnNext(new WeatherChangeMessage(Temperature, Humidity, Pressure));
        }
    }

    public IDisposable Subscribe(IObserver<WeatherChangeMessage> observer)
    {
        observers.Add(observer);

        // no unsubscribe support
        // can be added with a disposable that contains a guid for the subscription and a weak reference to the observable
        return new EmptyDisposable();
    }
}
