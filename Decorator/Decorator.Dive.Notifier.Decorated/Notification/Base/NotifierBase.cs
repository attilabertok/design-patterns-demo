using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Decorated.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Decorated.Notification.Base;

public abstract class NotifierBase :
    INotifier
{
    protected NotifierBase(INotifier? wrappedNotifier = null)
    {
        WrappedNotifier = wrappedNotifier;
    }

    protected INotifier? WrappedNotifier { get; }

    public virtual void Send(string message)
    {
        WrappedNotifier?.Send(message);
    }

    public virtual void Subscribe(Subscriber subscriber)
    {
        WrappedNotifier?.Subscribe(subscriber);
    }
}
