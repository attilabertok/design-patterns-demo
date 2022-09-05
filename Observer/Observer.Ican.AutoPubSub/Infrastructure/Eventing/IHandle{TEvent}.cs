namespace Observer.Ican.AutoPubSub.Infrastructure.Eventing;

public interface IHandle<in TEvent>
    where TEvent : IEvent
{
    void Handle(object sender, TEvent eventArgs);
}
