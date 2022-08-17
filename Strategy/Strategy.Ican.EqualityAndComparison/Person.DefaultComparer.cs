namespace Strategy.Ican.EqualityAndComparison;

public partial class Person
{
    public static bool operator <(Person? left, Person? right)
    {
        return Comparer<Person>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(Person? left, Person? right)
    {
        return Comparer<Person>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(Person? left, Person? right)
    {
        return Comparer<Person>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(Person? left, Person? right)
    {
        return Comparer<Person>.Default.Compare(left, right) >= 0;
    }

    public static bool operator ==(Person? left, Person? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !Equals(left, right);
    }

    public int CompareTo(Person? other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        if (other is null)
        {
            return 1;
        }

        return Id.CompareTo(other.Id);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            return 1;
        }

        if (ReferenceEquals(this, obj))
        {
            return 0;
        }

        return obj is Person other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Person)}");
    }

    public bool Equals(Person? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        return obj is not null
               && (ReferenceEquals(this, obj) || (obj.GetType() == GetType() && Equals((Person)obj)));
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
