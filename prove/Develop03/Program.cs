using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //public static Reference _ref = new Reference();
    public static Reference _ref = new Reference(); 
    public Scripture _userChoice = new Scripture();
    static void Main(string[] args)
    {
        
        //References refes = new References();
        // refes._book = "Alma";
        // refes._chapter = 37;
        // refes._verse = 37;

       

        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        
        //Console.WriteLine(_userChoice._scrpt);
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        
        string choice = Console.ReadLine();
        while (true)
        {
          if (choice != "quit")
          {
              //break;
              Console.Clear();
              //refes.References();
             // _userChoice.scrptr();
          }
            
          Console.WriteLine("Bye, see you later.");
              
    }
}}