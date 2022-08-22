using Observer.Dive.TextEditor.Emailing;
using Observer.Dive.TextEditor.Infrastructure.Interfaces;
using Observer.Dive.TextEditor.Messages.Interfaces;

namespace Observer.Dive.TextEditor.Listeners;

public class EmailingListener : IObserver
{
    private readonly string emailAddress;
    private readonly string emailTemplate;

    public EmailingListener(string emailAddress, string emailTemplate)
    {
        this.emailAddress = emailAddress;
        this.emailTemplate = emailTemplate;
    }

    public void Update(IMessage message)
    {
        Console.WriteLine($"==> Sending email to {emailAddress}");
        Console.WriteLine("         with content:");
        Console.WriteLine($"{emailTemplate.Replace(Placeholder.Content, message.Content)}");
        Console.WriteLine();
    }
}
