using System.Diagnostics;

namespace Observer.HeadFirst.Common.WeatherStation;

[DebuggerDisplay("{Name}")]
public sealed class BarometricPressure : IEquatable<BarometricPressure>
{
    private readonly Guid id;

    private BarometricPressure(string name)
    {
        id = Guid.NewGuid();
        Name = name;
    }

    public static BarometricPressure Unknown { get; } = new(nameof(Unknown));

    public static BarometricPressure Low { get; } = new(nameof(Low));

    public static BarometricPressure Medium { get; } = new(nameof(Medium));

    public static BarometricPressure High { get; } = new(nameof(High));

    public string Name { get; }

    public static bool operator ==(BarometricPressure? left, BarometricPressure? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BarometricPressure? left, BarometricPressure? right)
    {
        return !Equals(left, right);
    }

    public static BarometricPressure FromValue(double value)
    {
        return value switch
        {
            > Threshold.BarometricPressure.HighLimit => High,
            > Threshold.BarometricPressure.MediumLimit => Medium,
            _ => Low
        };
    }

    public bool Equals(BarometricPressure? other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other) || id.Equals(other.id);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((BarometricPressure)obj);
    }

    public override int GetHashCode()
    {
        return id.GetHashCode();
    }
}
