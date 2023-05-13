using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static Journal _userChoice = new Journal();
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit ");
    
        List<string> personalPrompts;
        personalPrompts = new List<string>();
        //int x;
            //while (!int.TryParse(Console.ReadLine(), out x))
            //{
                Console.WriteLine("Please just 'numbers'!"); 
                
                int number = -1;
                while (number !=5)
                {
                    Console.WriteLine("What do you like to do? ");
                    string choice = Console.ReadLine();
                    number = int.Parse(choice); 
                        
                    if (number == 1)
                    {
                        _userChoice.DisplayPrompt();
                    }

                    if (number == 2)
                    {
                        _userChoice.DisplayEntries();
                    }
                    
                    if (number == 3)
                    {
                        _userChoice.LoadFromFile();
                    }
                    if (number == 4)
                    {
                        _userChoice.SaveToFile();
                    }
                        
                    if (number > 5 || number <= 0)
                    {
                        Console.WriteLine("Please just 'numbers' between 1 and 5!");
                    }
                    
                } 
                Console.WriteLine("Bye, see you later.");
            //break;
            //}           
    }
}