namespace Observer.Dive.TextEditor.Messages;

public record class FileSavedMessage(string FileName, DateTimeOffset Timestamp) : MessageBase
{
    public override string Content { get; } = $"The file {FileName} was saved at {Timestamp}";
}
