using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Naive.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Naive.Notification;

public class SmsNotifier :
    INotifier
{
    private readonly string phoneNumber;

    public SmsNotifier(Subscriber subscriber)
    {
        phoneNumber = subscriber.PhoneNumber;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS notification with '{message}' to '{phoneNumber}'.");
    }
}
