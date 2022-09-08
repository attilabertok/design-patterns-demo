namespace Decorator.Dive.Notifier.Common.Subscribers;

public class Subscriber
{
    public Subscriber(string fullName, string emailAddress, string phoneNumber, Guid facebookUserId)
    {
        FullName = fullName;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        FacebookUserId = facebookUserId;
    }

    public string FullName { get; set; }

    public string EmailAddress { get; set; }

    public string PhoneNumber { get; set; }

    public Guid FacebookUserId { get; set; }
}
