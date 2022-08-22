namespace Observer.HeadFirst.SelfImplemented.Infrastructure;

public interface IObserver
{
    void Update(double temperature, double humidity, double pressure);
}
