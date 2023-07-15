using System;
using System.Collections.Generic;
//Bicycle class - derived from Activity class
public class Bicycle : Activity
{
    //Private members variables
    private double _speed;

    // Constructor
    public Bicycle(DateTime date, int duration, double speed) : base(date, duration)
    {
        this._speed = speed;        
    }
    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Stacionary Bicycle ({FormatDuration()} min) - Speed: {_speed} mph";
    }
}