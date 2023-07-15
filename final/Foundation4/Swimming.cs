using System;
using System.Collections.Generic;
//Swimming class - derived from Activity class
public class Swimming : Activity
{
    //Private members variables
    private double _laps;

    // Constructor
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this._laps = laps;        
    }
    public override double GetDistance()
    {
        return Math.Round(_laps * 50.0, 2); // Each lap is 50 meters
    }

    public override double GetSpeed()
    {
        double distanceInKm = GetDistance() / 1000.0;
        return Math.Round((distanceInKm / (GetDuration() / 60.0)), 2);
    }

    public override double GetPace()
    {
        double paceInMin = (GetDuration() / 60.0) / (GetDistance() / 1000.0); // Pace = time / distance
        return Math.Round(paceInMin, 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({FormatDuration()} min) - Distance {GetDistance()} meters, Speed {GetSpeed()} Km/h, Pace: {GetPace()} min per Km";
    }

}