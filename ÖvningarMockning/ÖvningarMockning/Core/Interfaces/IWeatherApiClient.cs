namespace ÖvningarMockning.Core.Interfaces
{
    public interface IWeatherApiClient
    {
        double GetTemperature(string city, DateTime date);
    }
}
