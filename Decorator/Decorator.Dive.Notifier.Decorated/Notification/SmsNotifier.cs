using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Decorated.Notification.Base;
using Decorator.Dive.Notifier.Decorated.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Decorated.Notification;

public class SmsNotifier :
    NotifierBase
{
    private readonly List<string> phoneNumbers = new();

    public SmsNotifier(INotifier? wrappedNotifier = null)
        : base(wrappedNotifier)
    {
    }

    public override void Subscribe(Subscriber subscriber)
    {
        phoneNumbers.Add(subscriber.PhoneNumber);

        base.Subscribe(subscriber);
    }

    public override void Send(string message)
    {
        foreach (var phoneNumber in phoneNumbers)
        {
            Console.WriteLine($"Sending SMS notification with '{message}' to '{phoneNumber}'.");
        }

        base.Send(message);
    }
}
