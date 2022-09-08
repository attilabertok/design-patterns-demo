using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Decorated.Notification.Base;
using Decorator.Dive.Notifier.Decorated.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Decorated.Notification;

public class EmailNotifier :
    NotifierBase
{
    private readonly List<string> addresses = new();

    public EmailNotifier(INotifier? wrappedNotifier = null)
        : base(wrappedNotifier)
    {
    }

    public override void Subscribe(Subscriber subscriber)
    {
        addresses.Add(subscriber.EmailAddress);

        base.Subscribe(subscriber);
    }

    public override void Send(string message)
    {
        foreach (var address in addresses)
        {
            Console.WriteLine($"Sending email notification with message '{message}' to '{address}'.");
        }

        base.Send(message);
    }
}
