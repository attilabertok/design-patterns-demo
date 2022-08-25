namespace Observer.GoF.Clock.Infrastructure;

public interface ISubject
{
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void Notify();
}
