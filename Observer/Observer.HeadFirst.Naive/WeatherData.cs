using System.Collections.Immutable;

using Observer.HeadFirst.Common.Displays;
using Observer.HeadFirst.Common.Displays.Interfaces;
using Observer.HeadFirst.Common.WeatherStation;

namespace Observer.HeadFirst.Naive;

public class WeatherData : WeatherDataBase
{
    private readonly ImmutableList<IWeatherDisplay> displays = new List<IWeatherDisplay>
    {
        new CurrentConditions(),
        new Statistics(),
        new Forecast(),
        new HeatIndex()
    }.ToImmutableList();

    public override void MeasurementsChanged()
    {
        foreach (var display in displays)
        {
            display.Update(Temperature, Humidity, Pressure);
        }
    }
}
