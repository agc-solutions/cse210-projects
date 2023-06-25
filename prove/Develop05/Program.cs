using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        GoalsGenetator _gen = new GoalsGenetator();
        int inputNumber = -1;
        while (inputNumber != 6)
        {
            //Console.Clear();
            Console.WriteLine("*** ETERNAL QUEST ***");
            Console.WriteLine("\nYou have   points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create a new goal.\n2. List of goals.\n3. Save goals.\n4. Load Goals.\n5. Record Event. \n6. Quit. ");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);

            
            //int userInput2 = 0;

            List<Goals> _goals = new List<Goals>();
            



            if (inputNumber == 1)
                    {
                        Console.WriteLine("\nThe types of goals are:");
                        Console.WriteLine("\nA. Simple Goal. \nB. Eternal Goal. \nC. Checklist Goal.");
                        Console.Write("\nWhich type of goal would you like to create? ");
                        string inputType = Console.ReadLine();

                        //string inputType = "";
                        if (inputType.ToUpper() == "A" || inputType.ToUpper() == "B")
                        {
                            _gen.Goals();
                            //_gen.List();
                        }
 
                        

                        // public void entry()
                        // {
                        //     int inputPoints = 0;
                        //     Console.Write("What is the name of your goal? ");
                        //     string nameOfGoal = Console.ReadLine();
                        //     Console.Write("What is a short description of it? ");
                        //     string description = Console.ReadLine();
                        //     Console.Write("What is amount of points associated with this goal? ");
                        //     string userPoints = Console.ReadLine();
                        //     inputPoints = int.Parse(userPoints);
                        // }
                        

                        // if (inputType == "A" || inputType == "B" || inputType == "C")
                        // {
                        //     int inputPoints = 0;
                        //     Console.Write("What is the name of your goal? ");
                        //     string nameOfGoal = Console.ReadLine();
                        //     Console.Write("What is a short description of it? ");
                        //     string description = Console.ReadLine();
                        //     Console.Write("What is amount of points associated with this goal? ");
                        //     string userPoints = Console.ReadLine();
                        //     inputPoints = int.Parse(userPoints);
                        //    // public List<string> _theGoals = new List<string>();
                        //     string _theGoal;

                        //     _theGoal = ($"\nOlá: [ ] {nameOfGoal} ({description})");
                            
                        //     //Console.WriteLine(_theGoal);
                        //     //Console.writeline(_theGoals);
                        //     Console.WriteLine(_theGoal);
                        // }
                        // if (inputType != "A" || inputType != "B" || inputType != "C")
                        // {
                        
                        Console.WriteLine("Please just 'numbers' between 1 and 5!");
                        //}
                        //else ()
                    }

                    else if (inputNumber == 2)
                    {
                        Console.Write("List\n");
                    }

        }
        // public void StoreGoals()
        // {
        //     _goals.Add(_theGoal)
        // }
        //Console.WriteLine(Goals);
        Console.WriteLine("\nBye, see you later.");
        
    }
}