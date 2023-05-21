using System;

class Program
{
    public static Scripture _userChoice = new Scripture();
    public static Reference _ref = new Reference();
        
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        
        Console.WriteLine( _userChoice._scrpt);
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        
        string choice = Console.ReadLine();
        //while (true)
        //{
            if (choice != "quit")
            {
                //break;
                Console.Clear();
                _userChoice.scrptr();
            }
            
            Console.WriteLine("Bye, see you later.");
            

        
        
    }
}