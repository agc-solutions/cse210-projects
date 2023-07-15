using System;
using System.Collections.Generic;
//Running class - derived from Activity class
public class Running : Activity
{
    //Private members variables
    private double _distance;
    

    // Constructors
    public Running(DateTime date, int duration, double distance) : base (date, duration)
    {
        this._distance = distance;    
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double distanceInMiles = _distance / 1.61; // Convert distance form Km to Miles
        return Math.Round((distanceInMiles / (GetDuration() /60.0)), 2); // Speed = distance / time
    }

    public override double GetPace()
    {
        double paceInMin = (GetDuration() / 60.0) / (_distance / 1.61); // Pace = time / distance
        return Math.Round(paceInMin, 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({FormatDuration()} min) - Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}