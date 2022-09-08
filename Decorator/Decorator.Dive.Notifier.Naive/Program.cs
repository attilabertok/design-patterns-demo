using Decorator.Dive.Notifier.Common.Subscribers.Factories;
using Decorator.Dive.Notifier.Naive.Notification;
using Decorator.Dive.Notifier.Naive.Notification.Interfaces;

namespace Decorator.Dive.Notifier.Naive
{
    public static class Program
    {
        public static void Main()
        {
            SimpleNotifiers();
            CombinedNotifiers();
        }

        private static void SimpleNotifiers()
        {
            var emailingUser = SubscriberFactory.Create();
            var smsUser = SubscriberFactory.Create();
            var facebookUser = SubscriberFactory.Create();

            // TODO: instead of having to register to all notification types, we would prefer to have combined notifiers
            var admin = SubscriberFactory.Create();

            var notifiers = new List<INotifier>
            {
                new EmailNotifier(emailingUser),
                new SmsNotifier(smsUser),
                new FacebookNotifier(facebookUser),
                new EmailNotifier(admin),
                new SmsNotifier(admin),
                new FacebookNotifier(admin)
            };

            foreach (var notifier in notifiers)
            {
                notifier.Send("A somewhat important event");
            }
        }

        private static void CombinedNotifiers()
        {
            var emailingUser = SubscriberFactory.Create();
            var smsUser = SubscriberFactory.Create();
            var facebookUser = SubscriberFactory.Create();

            // TODO: to create combinations of notifiers, we would have to create many classes
            var admin = SubscriberFactory.Create();

            var notifiers = new List<INotifier>
            {
                new EmailNotifier(emailingUser),
                new SmsNotifier(smsUser),
                new FacebookNotifier(facebookUser),
                new EmailAndSmsNotifier(admin),
                new FacebookNotifier(admin)
            };

            foreach (var notifier in notifiers)
            {
                notifier.Send("A somewhat important event");
            }
        }
    }
}
