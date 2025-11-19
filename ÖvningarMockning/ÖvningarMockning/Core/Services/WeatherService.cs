using ÖvningarMockning.Core.Interfaces;

public class WeatherService
{
    private readonly IWeatherApiClient _client;

    public WeatherService(IWeatherApiClient client)
    {
        _client = client;
    }

    public double GetTodaysTemperature(string city)
    {
        return _client.GetTemperature(city, DateTime.Today);
    }
}