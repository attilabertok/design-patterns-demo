using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Naive.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Naive.Notification;

public class EmailNotifier :
    INotifier
{
    private readonly string emailAddress;

    public EmailNotifier(Subscriber subscriber)
    {
        emailAddress = subscriber.EmailAddress;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sending email notification with message '{message}' to '{emailAddress}'.");
    }
}
