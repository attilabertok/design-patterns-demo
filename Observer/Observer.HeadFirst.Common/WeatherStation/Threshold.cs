namespace Observer.HeadFirst.Common.WeatherStation;

public static class Threshold
{
    public static class BarometricPressure
    {
        public const int UpperBound = 120;

        public const int HighLimit = 81;

        public const int MediumLimit = 41;

        public const int LowerBound = 0;
    }

    public static class Temperature
    {
        public const int UpperBound = 40;

        public const int LowerBound = -20;
    }

    public static class Humidity
    {
        public const int UpperBound = 100;

        public const int LowerBound = 0;
    }
}
