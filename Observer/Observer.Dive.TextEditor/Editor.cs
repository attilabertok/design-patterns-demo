using Observer.Dive.TextEditor.Infrastructure;
using Observer.Dive.TextEditor.Messages;

namespace Observer.Dive.TextEditor;

public class Editor
{
    public EventManager EventManager { get; } = new();

    public void OpenFile(string fileName)
    {
        EventManager.NotifyObservers(new FileOpenedMessage(fileName));
    }

    public void SaveFile(string fileName)
    {
        EventManager.NotifyObservers(new FileSavedMessage(fileName, DateTime.UtcNow));
    }
}
