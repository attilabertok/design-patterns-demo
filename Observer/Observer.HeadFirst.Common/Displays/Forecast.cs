using Observer.HeadFirst.Common.Displays.Interfaces;
using Observer.HeadFirst.Common.Messages;
using Observer.HeadFirst.Common.WeatherStation;

namespace Observer.HeadFirst.Common.Displays;

public class Forecast : IWeatherDisplay
{
    private double previousPressure;

    public void Update(WeatherChangeMessage message)
    {
        var forecast = "Unknown";
        if (Math.Abs(previousPressure) > 0.1d)
        {
            var pressureDifference = BarometricPressureChange.FromPressureDifference(message.Pressure, previousPressure);

            forecast = CalculateForecast(BarometricPressure.FromValue(message.Pressure), pressureDifference);
        }

        Console.WriteLine("==== Forecast for the next 12 to 24 hours: ====");
        Console.WriteLine(forecast);
        Console.WriteLine();

        previousPressure = message.Pressure;
    }

    private static string CalculateForecast(BarometricPressure pressure, BarometricPressureChange pressureDifference)
    {
        if (pressure == BarometricPressure.Unknown || pressureDifference == BarometricPressureChange.Unknown)
        {
            return "Unknown";
        }

        if (pressure == BarometricPressure.Low)
        {
            return CalculateLowPressureForecast(pressureDifference);
        }

        if (pressure == BarometricPressure.Medium)
        {
            return CalculateMediumPressureForecast(pressureDifference);
        }

        return CalculateHighPressureForecast(pressureDifference);
    }

    private static string CalculateLowPressureForecast(BarometricPressureChange pressureDifference)
    {
        if (pressureDifference == BarometricPressureChange.RapidlyFalling)
        {
            return "Impending storm";
        }

        if (pressureDifference == BarometricPressureChange.SlowlyFalling)
        {
            return "Certain precipitation";
        }

        return "Clearing weather, declining temperatures";
    }

    private static string CalculateMediumPressureForecast(BarometricPressureChange pressureDifference)
    {
        if (pressureDifference == BarometricPressureChange.RapidlyFalling)
        {
            return "Likely precipitation";
        }

        if (pressureDifference == BarometricPressureChange.SlowlyFalling)
        {
            return "Expect only minor changes to the current weather";
        }

        return "Expect the same weather as now";
    }

    private static string CalculateHighPressureForecast(BarometricPressureChange pressureDifference)
    {
        if (pressureDifference == BarometricPressureChange.RapidlyFalling)
        {
            return "Cloud formation, increasing temperatures";
        }

        if (pressureDifference == BarometricPressureChange.SlowlyFalling)
        {
            return "Expect fair weather";
        }

        return "Expect continued fair weather";
    }
}
