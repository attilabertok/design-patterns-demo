namespace Observer.GoF.Clock.Infrastructure;

public abstract class SubjectBase : ISubject
{
    private readonly List<IObserver> observers = new();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
}
