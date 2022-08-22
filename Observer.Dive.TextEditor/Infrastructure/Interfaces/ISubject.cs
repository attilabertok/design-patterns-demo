using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Infrastructure.Interfaces;

public interface ISubject
{
    void Subscribe(Type messageType, IObserver observer);

    void Unsubscribe(Type messageType, IObserver observer);

    void NotifyObservers(IMessage message);
}
