using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        // Ask the user for their name.

        Console.Write("\r\nWhat is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        
        Console.WriteLine($"\r\nYour name is {last_name}, {first_name} {last_name}.\r\n");
    }
}