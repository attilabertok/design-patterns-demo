using Decorator.Dive.Notifier.Common.Subscribers;

namespace Decorator.Dive.Notifier.Decorated.Notification.Interfaces;

public interface INotifier
{
    void Send(string message);

    void Subscribe(Subscriber subscriber);
}
