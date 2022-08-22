using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Infrastructure.Interfaces;

public interface IObserver
{
    void Update(IMessage message);
}
