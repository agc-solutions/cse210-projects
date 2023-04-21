using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Core Requirements

        // 1. Ask the user for their grade percentage, then write a series 
        //    of if-elif-else statements to print out the appropriate letter grade. 
        //    (At this point, you'll have a separate print statement for each grade 
        //    letter in the appropriate block.)

        Console.Write("\r\nWhat's your grade percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);
        
        if (x >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (x >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (x >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }

        // 2. Assume that you must have at least a 70 to pass the class. 
        //    After determining the letter grade and printing it out. 
        //    Add a separate if statement to determine if the user passed 
        //    the course, and if so display a message to congratulate them. 
        //    If not, display a different message to encourage them for next time.

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed!\r\n");
        }
        else 
        {
            Console.WriteLine("Stay focused an you'll get it next time!\r\n");
        }

        // 3. Change your code from the first part, so that instead of printing the 
        //    letter grade in the body of each if, elif, or else block, instead create a 
        //    new variable called letter and then in each block, set this variable to the 
        //    appropriate value. Finally, after the whole series of if-elif-else statements, 
        //    have a single print statement that prints the letter grade once.

        Console.Write("\r\nWhat's your grade percentage? ");
        string grade2 = Console.ReadLine();
        int number = int.Parse(grade2);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}.\r\n");

        // Strech Challenge

        // 1. Add to your code the ability to include a "+" or "-" next to the letter grade,
        //    such as B+ or A-. For each grade, you'll know it is a "+" if the last digit is >= 7. 
        //    You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.
        //    After your logic to determine the grade letter, add another section to determine the 
        //    sign. Save this sign into a variable. Then, display both the grade letter and the sign
        //    in one print statement.
        //    Hint: To get the last digit, you could divide the number by 10, and get the remainder.
        //    You might refer back to the preparation material for Lesson 03 to see the operators 
        //    and find the one that does division and gives you the remainder.
        //    At this point, don't worry about the exceptional cases of A+, F+, or F-.

        int gradeSignal = number % 10;
        //Console.WriteLine(gradeSignal);

        string signal = "";
                      
        if (gradeSignal >= 7)
        {
            signal = "+";
        }
        else if (gradeSignal < 3)
        {
            signal = "-";
        }
        else
        {
            signal = " ";
        }

        // if (number > 93)
        // {
        //     signal = " ";

        // if (letter == "F")
        // {
        //     signal = " ";
        // }
        Console.WriteLine($"Your final grade is {letter}{signal}.");
    }
}
