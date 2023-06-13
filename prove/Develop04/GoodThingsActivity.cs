using System;
using System.Threading;

public class GoodThingsActivity
{
static Random rand = new Random();

// Display the starting message and prompt for the duration
public static int Start()
{
    Console.WriteLine("Welcome to the Good Things activity!");
    Console.Write("Please enter the duration (in seconds) for this activity: ");
    int duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Great! You will have {0} seconds to list as many good things as you can.", duration);
    return duration;
}

// Display a random prompt and wait for the user to start listing
public static void Prompt()
{
    string[] prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    string prompt = prompts[rand.Next(prompts.Length)];
    Console.WriteLine("Here is your prompt: {0}", prompt);
    Console.WriteLine("You have a few seconds to think before you start listing...");
    Thread.Sleep(3000); // Wait for 3 seconds
    Console.WriteLine("Go!");
}

// Ask the user to keep listing until the duration is over
public static int ListItems(int duration)
{
    DateTime endTime = DateTime.Now.AddSeconds(duration);
    int count = 0;
    while (DateTime.Now < endTime)
    {
        Console.Write("- ");
        Console.ReadLine(); // Wait for the user to enter an item
        count++;
    }
    return count;
}

// Display the number of items entered and the finishing message
public static void Finish(int count)
{
    Console.WriteLine("You listed {0} good things!", count);
    Console.WriteLine("That was a great exercise. Don't forget to be grateful for the good things in your life!");
}

// Main method to run the activity
// static void Maine()
// {
//     int duration = Start();
//     Prompt();
//     int count = ListItems(duration);
//     Finish(count);
// }
}
