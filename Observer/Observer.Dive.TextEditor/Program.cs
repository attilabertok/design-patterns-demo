using Observer.Dive.TextEditor.Emailing;
using Observer.Dive.TextEditor.Listeners;
using Observer.Dive.TextEditor.Messages;

namespace Observer.Dive.TextEditor
{
    public static class Program
    {
        private const string AdministratorEmailAddress = "admin@editorapp.com";

        public static void Main()
        {
            const string fileName = "C:\\my-favorite-file.txt";
            var editor = new Editor();

            CreateSubscriptions(editor);

            editor.OpenFile(fileName);
            editor.SaveFile(fileName);
        }

        private static void CreateSubscriptions(Editor editor)
        {
            var fileDate = DateOnly.FromDateTime(DateTime.Today).ToString()[..^1].Replace('.', '-');
            var logger = new LoggingListener($"C:\\Logs\\Editor-{fileDate}.log");
            var emailer = new EmailingListener(AdministratorEmailAddress, Template.ImportantEvent);

            editor.EventManager.Subscribe(typeof(FileOpenedMessage), logger);
            editor.EventManager.Subscribe(typeof(FileSavedMessage), logger);
            editor.EventManager.Subscribe(typeof(FileSavedMessage), emailer);
        }
    }
}
