using System;

class Program
{
    static void Main(string[] args)
    {
        
        //public static Reference _ref = new Reference(); 
        References refes = new References();
        refes._book = "Alma";
        refes._chapter = 37;
        refes._verse = 37;

        public Scripture _userChoice = new Scripture();

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
                refes.References();
                _userChoice.scrptr();
            }
            
            Console.WriteLine("Bye, see you later.");
              
    }
}