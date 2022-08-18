namespace Observer.HeadFirst.Common.Displays.Interfaces;

public interface IWeatherDisplay
{
    void Update(double temperature, double humidity, double pressure);
}
