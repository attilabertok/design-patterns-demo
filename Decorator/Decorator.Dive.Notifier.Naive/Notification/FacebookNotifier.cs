using Decorator.Dive.Notifier.Common.Subscribers;
using Decorator.Dive.Notifier.Naive.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Naive.Notification;

public class FacebookNotifier :
    INotifier
{
    private readonly string userName;
    private readonly Guid userId;

    public FacebookNotifier(Subscriber subscriber)
    {
        userName = subscriber.FullName;
        userId = subscriber.FacebookUserId;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Sending Facebook notification with '{message}' to '{userName} ({userId})'.");
    }
}
