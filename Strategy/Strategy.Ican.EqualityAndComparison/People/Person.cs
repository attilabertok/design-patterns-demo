using System.Globalization;
using System.Text;

namespace Strategy.Ican.EqualityAndComparison.People;

public partial class Person :
    IEquatable<Person>,
    IComparable<Person>,
    IComparable
{
    public Person(string name, DateOnly dateOfBirth)
    {
        Id = Guid.NewGuid();
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public Guid Id { get; }

    public string Name { get; }

    public DateOnly DateOfBirth { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine("Person")
            .Append("Id: ").AppendLine(Id.ToString())
            .Append("Name: ").AppendLine(Name)
            .Append("Date of birth: ").AppendLine(DateOfBirth.ToString(CultureInfo.InvariantCulture));

        return sb.ToString();
    }
}
