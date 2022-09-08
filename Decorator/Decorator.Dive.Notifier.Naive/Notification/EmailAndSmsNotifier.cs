using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Naive.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Naive.Notification;

public class EmailAndSmsNotifier :
    INotifier
{
    private readonly string emailAddress;
    private readonly string phoneNumber;

    public EmailAndSmsNotifier(Subscriber subscriber)
    {
        emailAddress = subscriber.EmailAddress;
        phoneNumber = subscriber.PhoneNumber;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sending email notification with message '{message}' to '{emailAddress}'.");
        Console.WriteLine($"Sending SMS notification with '{message}' to '{phoneNumber}'.");
    }
}
