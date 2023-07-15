//Reception class - derived from Event
public class Receptions : Event
{
    //Private members variables
    private string _rsvpEmail;
    
    //constructor
    public Receptions (string eventTitle, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
    : base (eventTitle, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    // Override the GetFullDatails method to include rsvpEmail email
    //public override string GetFullDetails() -> to polimorphism
    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nrsvpEmail Email: {_rsvpEmail}";

    }

}

   