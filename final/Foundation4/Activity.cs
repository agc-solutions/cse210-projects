using System;
using System.Collections.Generic;
//Base class for Activity
public abstract class Activity
{
    //Private members variables
    private DateTime _date;// {get; set; }
    //private int _lengthInMinutes;
    private int _duration;// {get; set; }
    

// Constructor

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public virtual double GetDistance()
    {
        return 0;
    }

    //public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return 0;
    }
    //public abstract double GetSpeed();

    public virtual double GetNumberOfLaps()
    {
        return 0;
    }
    //public abstract double GetNumberOfLaps();

    public virtual double GetPace()
    {
        return 0;
    }
    //public abstract double GetPace();

    public virtual string GetSummary()
    {
        return "";
    }

    //public abstract string GetSummary();

    protected string FormatDuration()
    {
        TimeSpan time = new TimeSpan(0, _duration, 0);
        return time.ToString(@"hh\:mm");
    }

}