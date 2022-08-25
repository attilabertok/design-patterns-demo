using Observer.Dive.TextEditor.Infrastructure.Interfaces;

namespace Observer.Dive.TextEditor.Infrastructure;

public static class ListenerExtensions
{
    public static void Subscribe(this IDictionary<Type, List<IObserver>> listeners, Type messageType, IObserver observer)
    {
        listeners.CreateObserverListIfRequired(messageType);
        listeners[messageType].Add(observer);
    }

    public static void Unsubscribe(this IDictionary<Type, List<IObserver>> listeners, Type messageType, IObserver observer)
    {
        if (listeners.HasSubscribersForMessageType(messageType) && listeners.IsObservedForMessageType(messageType, observer))
        {
            listeners[messageType].Remove(observer);
        }
    }

    public static List<IObserver> GetListenersFor(this IDictionary<Type, List<IObserver>> listeners, Type messageType)
    {
        return listeners.HasSubscribersForMessageType(messageType)
            ? listeners[messageType]
            : Enumerable.Empty<IObserver>().ToList();
    }

    private static void CreateObserverListIfRequired(this IDictionary<Type, List<IObserver>> listeners, Type messageType)
    {
        if (!HasSubscribersForMessageType(listeners, messageType))
        {
            listeners.Add(messageType, new List<IObserver>());
        }
    }

    private static bool HasSubscribersForMessageType(this IDictionary<Type, List<IObserver>> listeners, Type messageType)
    {
        return listeners.ContainsKey(messageType);
    }

    private static bool IsObservedForMessageType(this IDictionary<Type, List<IObserver>> listeners, Type messageType, IObserver observer)
    {
        return listeners[messageType].Contains(observer);
    }
}
