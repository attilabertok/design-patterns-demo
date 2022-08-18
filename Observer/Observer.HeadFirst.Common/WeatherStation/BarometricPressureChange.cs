using System.Diagnostics;

namespace Observer.HeadFirst.Common.WeatherStation;

[DebuggerDisplay("{Name}")]
public sealed class BarometricPressureChange : IEquatable<BarometricPressureChange>
{
    private readonly Guid id;

    private BarometricPressureChange(string name)
    {
        Name = name;
        id = Guid.NewGuid();
    }

    public static BarometricPressureChange Unknown { get; } = new(nameof(Unknown));

    public static BarometricPressureChange RisingOrSteady { get; } = new(nameof(RisingOrSteady));

    public static BarometricPressureChange SlowlyFalling { get; } = new(nameof(SlowlyFalling));

    public static BarometricPressureChange RapidlyFalling { get; } = new(nameof(RapidlyFalling));

    public string Name { get; }

    public static bool operator ==(BarometricPressureChange? left, BarometricPressureChange? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BarometricPressureChange? left, BarometricPressureChange? right)
    {
        return !Equals(left, right);
    }

    public static BarometricPressureChange FromPressureDifference(double currentValue, double previousValue)
    {
        var difference = currentValue - previousValue;

        return difference switch
        {
            < -10 => RapidlyFalling,
            < -5 => SlowlyFalling,
            _ => RisingOrSteady
        };
    }

    public bool Equals(BarometricPressureChange? other)
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

        return Equals((BarometricPressureChange)obj);
    }

    public override int GetHashCode()
    {
        return id.GetHashCode();
    }
}
