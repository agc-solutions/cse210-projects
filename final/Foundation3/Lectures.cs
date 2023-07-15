//Lecture class - derived from Event class
public class Lectures : Event
{
    //Private members variables
    private string _speaker;
    private int _limitedCapacity;

    //Constructor
    public Lectures(string eventTitle, string description, DateTime date, TimeSpan time, Address address, string speaker, int limitedCapacity)
    : base (eventTitle, description, date, time, address)
    {
        this._speaker = speaker;
        this._limitedCapacity = limitedCapacity;
    }

    // Override the GetFullDatails method to include speaker and capacity
    //public override string GetFullDetails() -> to polimorphism
    public string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_limitedCapacity}";

    }

}