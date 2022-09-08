using Decorator.Dive.Notifier.Common.Subscribers.Factories;
using Decorator.Dive.Notifier.Decorated.Notification;

namespace Decorator.Dive.Notifier.Decorated
{
    public static class Program
    {
        public static void Main()
        {
            var emailingUser = SubscriberFactory.Create();
            var smsUser = SubscriberFactory.Create();
            var facebookUser = SubscriberFactory.Create();

            // TODO: to create combinations of notifiers, we would have to create many classes
            var admin = SubscriberFactory.Create();

            var infoNotifier = new EmailNotifier();
            infoNotifier.Subscribe(emailingUser);

            var warningNotifier = new SmsNotifier(new EmailNotifier());
            warningNotifier.Subscribe(smsUser);
            warningNotifier.Subscribe(emailingUser);

            var facebookNotifier = new FacebookNotifier();
            facebookNotifier.Subscribe(facebookUser);

            var errorNotifier = new EmailNotifier(new SmsNotifier(new FacebookNotifier()));
            errorNotifier.Subscribe(admin);

            infoNotifier.Send("A somewhat important event");
            warningNotifier.Send("A warning");
            facebookNotifier.Send("An insignificant event");
            errorNotifier.Send("Oh the humanity!");
        }
    }
}
