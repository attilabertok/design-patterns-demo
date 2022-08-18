using Observer.HeadFirst.Common.Infrastructure;

namespace Observer.HeadFirst.Common.WeatherStation;

public abstract class WeatherDataBase
{
    private double temperature;
    private double humidity;
    private double pressure;

    protected WeatherDataBase()
    {
        var random = new Random();

        var parameters = new List<WeatherParameter>
        {
            new(random, new Range<double>(Threshold.Temperature.LowerBound, Threshold.Temperature.UpperBound), value => Temperature = value),
            new(random, new Range<double>(Threshold.Humidity.LowerBound, Threshold.Humidity.UpperBound), value => Humidity = value),
            new(random, new Range<double>(Threshold.BarometricPressure.LowerBound, Threshold.BarometricPressure.UpperBound), value => Pressure = value),
        };
    }

    public double Temperature
    {
        get => temperature;
        private set
        {
            if (!(Math.Abs(temperature - value) > 0.5d))
            {
                return;
            }

            temperature = value;
            MeasurementsChanged();
        }
    }

    public double Humidity
    {
        get => humidity;
        private set
        {
            if (!(Math.Abs(humidity - value) > 0.5d))
            {
                return;
            }

            humidity = value;
            MeasurementsChanged();
        }
    }

    public double Pressure
    {
        get => pressure;
        private set
        {
            if (!(Math.Abs(pressure - value) > 0.5d))
            {
                return;
            }

            pressure = value;
            MeasurementsChanged();
        }
    }

    public abstract void MeasurementsChanged();
}
