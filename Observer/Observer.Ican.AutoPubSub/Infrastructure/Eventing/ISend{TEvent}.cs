namespace Observer.Ican.AutoPubSub.Infrastructure.Eventing;

public interface ISend<TEvent>
    where TEvent : IEvent
{
    event EventHandler<TEvent> Sender;
}
