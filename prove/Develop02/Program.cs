using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit ");
    
        List<string> personalPrompsts;
        personalPrompsts = new List<string>();
        
        int number = -1;
        while (number !=5)
        {
            Console.WriteLine("What do you like to do? ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);        
            if (number == 1)
            {
                PromptGenerator myPromptGenerator = new PromptGenerator();
                myPromptGenerator.Display();
                string response = Console.ReadLine();

                string filename = "thoughts.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(response);
                }

                Write t1 = new Write();
                t1._thoughts = response;
                DateTime theCurrentTime = DateTime.Now;

                List<Write> thoughts = new List<Write>();
                thoughts.Add(t1);

                foreach (Write t in thoughts)
                {
                    Console.WriteLine(t._thoughts);
                }

                // Write newWrite = new Write();
                // thoughts.Add(newWrite);

                SaveToFile(thoughts);

                static void SaveToFile(List<Write> thoughts)
                {
                    string filename = "thoughts.txt";
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (Write t in thoughts)
                        {
                            outputFile.WriteLine($"{DateTime.Now.ToShortDateString()} - {t._thoughts}");
                        }
                    }
                }
                

            }

            if (number == 2)
            {
               List<Write> newThoughts = ReadFromFile();
                foreach (Write t in newThoughts)
                {
                    Console.WriteLine(t._thoughts);
                }
                static List<Write> ReadFromFile()
                {
                    List<Write> thoughts = new List<Write>();
                    string filename = "thoughts.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }

                    return thoughts;
                } 
            }
            
            if (number == 3)
            {
                
            }
            
            if (number == 4)
            {
                
            }

            if (number > 5)
            {
                Console.WriteLine("Just 1 to 5, please!");
            }
            
        } 
        Console.WriteLine("Bye, see you later.");
    }
}