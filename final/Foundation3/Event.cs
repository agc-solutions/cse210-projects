//Base class for Event
public class Event
{
    //Private members variables
    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address; 

    // Constructor
    public Event (string eventTitle, string description, DateTime date, TimeSpan time, Address address)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    // Method to generate standard details message
    // Standard details - Lists the title, description, date, time, and address.
    //public virtual string GetStandardDetails() -> to polimorphism
    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToString()}\nAddress: {_address.GetAddress()}";
    }

    //Method to generate full details message
    // Full details - Lists all of the above, plus type of event and information specific to that event type. 
    // For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. 
    // For outdoor gatherings, this includes a statement of the weather.
    //public virtual string GetFullDetails() -> to polimorphism
    public string GetFullDetails()
    {
        //return GetStandardDetails(); -> to polimorphism
        return $"{GetStandardDetails()}\nType: FULL DETAILS";
    }

    //Method to generate short details message
    // Short description - Lists the type of event, title, and the date.

    //public virtual string GetShortDescription() -> to polimorphism
    public string GetShortDescription()
    {
        //return $"Type: Event\nTitle: {_eventTitle}\nDate: {_date.ToShortDateString()}";
        return $"Type: SHORT DESCRIPTION\nTitle: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}