using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        // Ask the user for their name.

        Console.Write("\r\nWhat is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine($"\r\nYour name is {lastName}, {firstName} {lastName}.\r\n");
    }
}