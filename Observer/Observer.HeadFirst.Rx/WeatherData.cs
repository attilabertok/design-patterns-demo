using System.Reactive.Subjects;

using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.Common.WeatherStation;

namespace Observer.HeadFirst.Rx;

public class WeatherData :
    WeatherDataBase,
    IObservable<WeatherChangeMessage>
{
    private readonly Subject<WeatherChangeMessage> subject;

    public WeatherData()
    {
        subject = new Subject<WeatherChangeMessage>();
    }

    public override void MeasurementsChanged()
    {
        subject.OnNext(new WeatherChangeMessage(Temperature, Humidity, Pressure));
    }

    public IDisposable Subscribe(IObserver<WeatherChangeMessage> observer)
    {
        return subject.Subscribe(observer);
    }
}
