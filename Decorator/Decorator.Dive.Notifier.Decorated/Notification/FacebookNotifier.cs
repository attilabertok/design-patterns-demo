using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Decorated.Notification.Base;
using Decorator.Dive.Notifier.Decorated.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Decorated.Notification;

public class FacebookNotifier :
    NotifierBase
{
    private readonly List<Subscriber> subscribers = new();

    public FacebookNotifier(INotifier? wrappedNotifier = null)
        : base(wrappedNotifier)
    {
    }

    public override void Subscribe(Subscriber subscriber)
    {
        subscribers.Add(subscriber);

        base.Subscribe(subscriber);
    }

    public override void Send(string message)
    {
        foreach (var subscriber in subscribers)
        {
            Console.WriteLine($"Sending Facebook notification with '{message}' to '{subscriber.FullName} ({subscriber.FacebookUserId})'.");
        }

        base.Send(message);
    }
}
