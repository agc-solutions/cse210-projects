using System;

class Program
{
    static void Main(string[] args)
    {
        // Overview

        // In the Guess My Number game the computer picks a magic number, 
        // and then the user tries to guess it. After each guess, the computer 
        // tells the user to guess "higher" or "lower" until they guess the magic number.
        // This assignment is a little tricky, because it brings together many of the 
        // concepts you've learned in this course including loops and if statements.

        // Core Requirements

        // Work through these core requirements step-by-step to complete the program. 
        // Please don't skip ahead and do the whole thing at once, because many people 
        // benefit from seeing the program built up step by step.

        // 1. Start by asking the user for the magic number. (In future steps, 
        //    we will change this to have the computer generate a random number, 
        //    but to get started, we'll just let the user decide what it is.)
        //    Ask the user for a guess.
        //    Using an if statement, determine if the user needs to guess higher or lower next time, 
        //    or tell them if they guessed it.
        //    At this point, you won't have any loops.
        Console.Write("\r\nPart 1");
        Console.Write("\r\nWhat is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
       

        if (guess > magicNumber)
        {
            Console.WriteLine("Lower.");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher.");
        }
        else 
        {
            Console.WriteLine("You guessed it.");
        }

        //2. Add a loop that keeps looping as long as the guess does not match the magic number.
        //   At this point, the user should be able to keep playing until they get the correct answer.

        Console.Write("\r\nPart 2");
        Console.Write("\r\nWhat is the magic number? ");
        int magicNumber2 = int.Parse(Console.ReadLine());        
        int guess2 = 0;

        while (guess2 != magicNumber2)
        {
            Console.Write("What is your guess? ");
            guess2 = int.Parse(Console.ReadLine());
            if (guess2 > magicNumber2)
            {
                Console.WriteLine("Lower.");
            }
            else if (guess2 < magicNumber2)
            {
                Console.WriteLine("Higher.");
            }
            else 
            {
                Console.WriteLine("You guessed it.");
            } 
        }
        

        //3. Instead of having the user supply the magic number, generate a random number from 1 to 100.
        //   Play the game and make sure it works!
        Console.WriteLine("\r\nPart 3");
        
        string response = "yes";        
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber3 = randomGenerator.Next(1,101);        
            int guess3 = -1; 
            int guessCount = 0; //Stretch Challenge 1
            while (guess3 != magicNumber3)
            {
                Console.Write("What is your guess? ");
                guess3 = int.Parse(Console.ReadLine());
                guessCount += 1; //Stretch Challenge 1
                if (guess3 > magicNumber3)
                {
                    Console.WriteLine("Lower.");
                }
                else if (guess3 < magicNumber3)
                {
                    Console.WriteLine("Higher.");
                }
                else 
                {
                    Console.WriteLine("You guessed it.");
                    Console.WriteLine($"It took you {guessCount} guesses.\r\n"); //Stretch Challenge 1
                } 
            }

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
            Console.Write('\n');
            if (response != "yes")
            {
               Console.WriteLine("Thank you. Bye.\r\n");
            }
            
        }       
            
    }
}