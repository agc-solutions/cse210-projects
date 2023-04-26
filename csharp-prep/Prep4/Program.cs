using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        //Assignment

        // Ask the user for a series of numbers, and append each one to a list. 
        // Stop when they enter 0.
        // Once you have a list, have your program do the following:
        
        // Core Requirements

        // Work through these core requirements step-by-step to complete the program. 
        // Please don't skip ahead and do the whole thing at once, because others on 
        // your team may benefit from building the program up slowly.

        // 1. Compute the sum, or total, of the numbers in the list.
        // 2. Compute the average of the numbers in the list.
        // 3. Find the maximum, or largest, number in the list.

        //Console.WriteLine("\r\nPart 1");
        //List<int> numbers = new List<int>();
        List<int> numbers;
        numbers = new List<int>();
        int number = -1;
        int total = 0;
        Console.WriteLine("\r\nEnter a list of numbers, type 0 when finished.");

        while(number != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if(number != 0)
            {
                numbers.Add(number);
            }
        }
        // A test
        // foreach (int num in numbers)
        // {
        // Console.WriteLine (num);
        // }

        // 1. Compute the sum, or total, of the numbers in the list.
        //Console.WriteLine("\r\nStep 1");
        foreach (int num in numbers)
        {
            total += num;            
        }
        Console.WriteLine($"The sum is: {total}");
        
        
        // 2. Compute the average of the numbers in the list.
        //Console.WriteLine("\r\nStep 2");
        //Console.WriteLine(numbers.Count); (Other test)
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // 3. Find the maximum, or largest, number in the list.
        //Console.WriteLine("\r\nStep 3");
        int largestNumber = -1;
        foreach(int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        //Stretch Challenge

        //1. Have the user enter both positive and negative numbers, 
        //   then find the smallest positive number (the positive 
        //   number that is closest to zero).

        int smallestOfAll = 999999999;
        foreach(int num in numbers)
        {
            if (num > 0 && num < smallestOfAll)
            {
                smallestOfAll = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestOfAll}");

        //2. Sort the numbers in the list and display the new, sorted 
        //   list. Hint: There are C# libraries that can help you here,
        //   try searching the internet for them.

        Console.WriteLine("The sorted list is:");

        // foreach (int num in numbers) #test
        // {
        //     Console.WriteLine(num);
        // }
        //     //var unsortedList = new List<int> {5, 2, 3, 1, 4};
            var unsortedList = numbers;
            var sortedList = new List<int>();            
            sortedList = new List<int>(unsortedList);            
            sortedList.Sort();
            // foreach (int i in unsortedList)
            // {
            //     Console.Write(i);
            // }
            // Console.Write('\n');
            foreach (int i in sortedList)
            {               
                Console.WriteLine(i);
            }
        
        // Console.WriteLine("The sorted list is:"); # My first attempt
        // foreach(num in sortedList)
        // {
        //     Console.Write(num);
        // }
        Console.Write('\n');

    }
}