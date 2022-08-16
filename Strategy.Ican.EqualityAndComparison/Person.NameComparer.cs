namespace Strategy.Ican.EqualityAndComparison;

public partial class Person
{
    public static IComparer<Person> NameComparer { get; } = new Person.NameRelationalComparer();

    private sealed class NameRelationalComparer
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

            return string.CompareOrdinal(x.Name, y.Name);
        }
    }
}
