using Observer.Dive.TextEditor.Infrastructure.Interfaces;
using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Infrastructure;

public class EventManager : ISubject
{
    private readonly Dictionary<Type, List<IObserver>> listeners = new();

    public void Subscribe(Type messageType, IObserver observer)
    {
        listeners.Subscribe(messageType, observer);
    }

    public void Unsubscribe(Type messageType, IObserver observer)
    {
        listeners.Unsubscribe(messageType, observer);
    }

    public void NotifyObservers(IMessage message)
    {
        foreach (var listener in listeners.GetListenersFor(message.GetType()))
        {
            listener.Update(message);
        }
    }
}
