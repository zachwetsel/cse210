public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
    : base(title, description, dateTime, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}\n";
    }
}