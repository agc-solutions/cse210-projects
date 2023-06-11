using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    //public static Activity2 _test = new Activity2();
    public static teste _ab = new teste();
    public static Spinner _sp = new Spinner();
    static void Main(string[] args)
    {
        // string[] questions =
        // {
        // "Why was this experience meaningful to you?",
        // "Have you ever done anything like this before?",
        // "How did you get started?",
        // "How did you feel when it was complete?",
        // "What made this time different than other times when you were not as successful?",
        // "What is your favorite thing about this experience?",
        // "What could you learn from this experience that applies to other situations?",
        // "What did you learn about yourself through this experience?",
        // "How can you keep this experience in mind in the future?"
        // };
        
        string ActvNam1 = "Breathing Activity";
        string ActvNam2 = "Refelction Activity";
        string ActvNam3 = "Listing Activity";

        string StrtMsg = "Hello";
        // string StrtMsg2 = "Hello";
        // string StrtMsg3 = "Hello";

        string AskDuration = "How long, in seconds, would you like for your session?";

        string DspMMsg = "";

        string Descrip1 = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        string Descrip2 = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        string Descrip3 = "reflect on the good things in your life by having you list as many things as you can in a certain area";
        //int duration;//int.Parse(Console.ReadLine());
        string EndMsg = $"You have completed another x seconds of the x Activity.";
        
        BreathingActivity DM = new BreathingActivity(ActvNam1, StrtMsg, AskDuration, 20, Descrip1, "DisplayMessages", EndMsg);
        

        //Activity2 a1 = new Activity2(ActvNam1, StrtMsg, AskDuration, duration, Descrip1, EndMsg);
        Activity2 a1 = new Activity2(ActvNam1, StrtMsg, AskDuration, 20, Descrip1, EndMsg);
        Activity2 a2 = new Activity2(ActvNam2, StrtMsg, AskDuration, 20, Descrip2, EndMsg);
        Activity2 a3 = new Activity2(ActvNam3, StrtMsg, AskDuration, 20, Descrip3, EndMsg);
        
        
        //ReflectionActivity r1 = new ReflectionActivity("Refelction Activity", "string[] questions",  "stdStartingQuestion", 20, "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", "thinkOf", "Question", "string stdFinishingMessage");
        int number = -1;
        int inputNumber = -1;  
         while (inputNumber != 4)
        {
        Console.Clear();
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Start Breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit ");
        Console.Write("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        inputNumber = int.Parse(userInput);
        Console.Clear();
 
        
        string actN = "";
        string dsctp = ""; 
        if (inputNumber == 1) {actN = a1.GetActivityName(); dsctp = a1.GetDescription();}
        if (inputNumber == 2) {actN = a2.GetActivityName(); dsctp = a2.GetDescription();}
        if (inputNumber == 3) {actN = a3.GetActivityName(); dsctp = a3.GetDescription();}

        
        //string rflct = "";
        

        //if (inputNumber != 4)
       
            Console.WriteLine($"Welcome to the {actN}.");//starting message
            Console.WriteLine($"\nThis activity will help you {dsctp}.");//starting message

            if (inputNumber == 1 || inputNumber == 2 || inputNumber == 3)
            {
                string qstn = a1.GetStdStartingQuestion();
                Console.WriteLine($"\n{qstn} ");//starting message 
                int duration = int.Parse(Console.ReadLine()); 
                Console.Clear(); 
                Console.WriteLine("Get ready...");
                _sp.DisplaySpinner();
               
                if (inputNumber == 1)
                {
                    DM.DisplayMessages(duration);
                    //a1.GetStdFinishingMessage();
                    Console.WriteLine($"You have completed another {duration} seconds of the {actN} Activity.");
                }
                else if (inputNumber == 2)
                {
                    Console.WriteLine("\nConsider the following prompt:\n");
                    ThinkOf thinkOf = new ThinkOf();
                    thinkOf.Thnk();
                    string prompt = thinkOf._chosen;
                    Console.WriteLine($"---{prompt}---\n");
                    ReflQuestions reflQuestions = new ReflQuestions();
                    reflQuestions.InMind();
                    _sp.DisplaySpinner();
                    string[] questions = reflQuestions.questions; 
                    Console.Clear();
                    foreach (string question in questions) {
                    Console.WriteLine(question);
                    _sp.DisplaySpinner(); 
                }                                   
                }
                else if (inputNumber == 3)
                {
                    Console.WriteLine("\nList as many response you can to the following prompt:");
                    // ListingActivity la = new ListingActivity(actN,"","", 0,"", chosenPrompt, "");
                    // la.DisplayPrompt();
                    // Console.WriteLine(prompts)
                    
                }
                if (inputNumber > 4 || inputNumber <= 0)
                    {
                        Console.WriteLine("Please just 'numbers' between 1 and 4!");
                    }
            
                Console.WriteLine($"You have completed another {duration} seconds of the {actN} Activity.");

            }         
        }
        Console.WriteLine("\nBye, see you later.\n");       
    }
}