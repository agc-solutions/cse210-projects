//OutdoorGatherings class - derived from Event class
public class OutdoorGatherings : Event
{
    //Private members variables
    private string _weather;

    //Constructor
    public OutdoorGatherings (string eventTitle, string description, DateTime date, TimeSpan time, Address address, string weather) : base (eventTitle, description, date, time, address)
    {
        this._weather = weather;
    }

    // Override the GetFullDatails method to include weather forecast
    //public override string GetFullDetails() -> to polimorphism
    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather ForeCast: {_weather}";

    }
}