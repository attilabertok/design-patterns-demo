namespace Observer.Dive.TextEditor.Messages;

public record class FileOpenedMessage(string FileName) : MessageBase
{
    public override string Content { get; } = $"The file {FileName} was opened";
}
