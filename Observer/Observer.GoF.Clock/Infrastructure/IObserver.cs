namespace Observer.GoF.Clock.Infrastructure;

public interface IObserver
{
    void Update(ISubject changedSubject);
}
