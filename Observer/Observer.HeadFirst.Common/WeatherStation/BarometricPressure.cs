namespace Observer.HeadFirst.Common.WeatherStation;

public class BarometricPressure
{
    private BarometricPressure()
    {
    }

    public static BarometricPressure Unknown => new();

    public static BarometricPressure Low => new();

    public static BarometricPressure Medium => new();

    public static BarometricPressure High => new();

    public static BarometricPressure FromValue(double value)
    {
        return value switch
        {
            > Threshold.BarometricPressure.HighLimit => High,
            > Threshold.BarometricPressure.MediumLimit => Medium,
            _ => Low
        };
    }
}
