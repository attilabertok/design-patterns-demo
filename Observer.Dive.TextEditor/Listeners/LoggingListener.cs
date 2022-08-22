using Observer.Dive.TextEditor.Infrastructure.Interfaces;
using Observer.Dive.TextEditor.Messages;
using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Listeners;

public class LoggingListener : IObserver
{
    private readonly string logFileName;

    public LoggingListener(string logFileName)
    {
        this.logFileName = logFileName;
    }

    public void Update(IMessage message)
    {
        Console.WriteLine($"==> Writing message to {logFileName}:");
        Console.WriteLine(message.Content);
        Console.WriteLine();
    }
}
