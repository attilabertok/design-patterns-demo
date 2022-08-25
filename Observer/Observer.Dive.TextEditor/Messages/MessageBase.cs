using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Messages;

public abstract record class MessageBase() :
    IMessage
{
    public Guid Id { get; } = Guid.NewGuid();

    public abstract string Content { get; }
}
