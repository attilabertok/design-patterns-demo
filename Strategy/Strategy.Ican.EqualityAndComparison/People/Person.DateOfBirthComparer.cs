namespace Strategy.Ican.EqualityAndComparison.People;

public partial class Person
{
    public static IComparer<Person> DateOfBirthComparer { get; } = new Person.DateOfBirthRelationalComparer();

    private sealed class DateOfBirthRelationalComparer
        : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (y is null)
            {
                return 1;
            }

            if (x is null)
            {
                return -1;
            }

            return x.DateOfBirth.CompareTo(y.DateOfBirth);
        }
    }
}
