using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create a running activity
        DateTime runningDate = new DateTime (2023, 7, 14);
        int runningLengthInMinuts = 120;
        double runningDistance = 4.0;
        Activity running = new Running(runningDate,runningLengthInMinuts, runningDistance);
        activities.Add(running);

        // Create a stationay bicycle activity
        DateTime bicycleDate = new DateTime (2023, 7, 14);
        int bicycleLengthInMinuts = 60;
        double bicycleSpeed = 14.0;
        Activity bicycle = new Bicycle(bicycleDate,bicycleLengthInMinuts, bicycleSpeed);
        activities.Add(bicycle);

        // Create a swimming activity
        DateTime swimmingDate = new DateTime (2023, 7, 14);
        int swimmingLengthInMinuts = 5;
        int swimmingLaps = 4;
        Activity swimming = new Swimming(swimmingDate,swimmingLengthInMinuts, swimmingLaps);
        activities.Add(swimming);

        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        //Console.ReadLine();
        Console.WriteLine();

    }
}