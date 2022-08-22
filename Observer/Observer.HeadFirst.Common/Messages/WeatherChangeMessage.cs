namespace Observer.HeadFirst.Common.Messages;

public record struct WeatherChangeMessage(double Temperature, double Humidity, double Pressure);
