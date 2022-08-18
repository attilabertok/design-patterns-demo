namespace Observer.HeadFirst.Common.WeatherStation;

public class BarometricPressureChange
{
    private BarometricPressureChange()
    {
    }

    public static BarometricPressureChange Unknown => new();

    public static BarometricPressureChange RisingOrSteady => new();

    public static BarometricPressureChange SlowlyFalling => new();

    public static BarometricPressureChange RapidlyFalling => new();

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
}
