using Observer.Ican.PropertyDependencies.Naive.Infrastructure.Models;

namespace Observer.Ican.PropertyDependencies.Naive.People;

public class Person :
    NaiveModelBase
{
    private string name;
    private string nationality;

    public Person(
        string name,
        DateOnly dateOfBirth,
        string nationality)
    {
        this.name = name;
        DateOfBirth = dateOfBirth;
        this.nationality = nationality;
    }

    public string Name
    {
        get => name;
        private set => SetField(ref name, value);
    }

    public DateOnly DateOfBirth { get; }

    public string Nationality
    {
        get => nationality;
        set => SetField(ref nationality, value);
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(DateOfBirth)}: {DateOfBirth}, {nameof(Nationality)}: {Nationality}";
    }
}
