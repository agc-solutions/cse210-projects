using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Create sample address
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "12345");
        Address address2 = new Address("456 Elm St", "Townsville", "Stateville", "54321");
        Address address3 = new Address("789 Oak St", "Villageville", "Stateville", "98765");

        // Create sample events
        Event event1 = new Event("Event 1", "Description 1", DateTime.Now, TimeSpan.FromHours(1), address1);
        Lectures lecture1 = new Lectures("Lecture 1", "Lecture Description 1", DateTime.Now, TimeSpan.FromHours(2), address2, "Speaker 1", 100);
        Receptions reception1 = new Receptions("Reception 1", "Reception Description 1", DateTime.Now, TimeSpan.FromHours(3), address3, "email@example.com");
        OutdoorGatherings outdoorGathering1 = new OutdoorGatherings("Outdoor Gathering 1", "Outdoor Gathering Description 1", DateTime.Now, TimeSpan.FromHours(4), address1, "Sunny");

        // Generate marketing messages for each event
        Console.WriteLine("Event 1:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("\nLECTURE EVENT 1:");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("\nRECEPTION EVENT 1:");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("\nOUTDOOR GATHERING EVENT 1:");
        Console.WriteLine(outdoorGathering1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering1.GetShortDescription());
        Console.WriteLine();
    }
}