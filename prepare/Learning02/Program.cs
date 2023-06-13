using System;

class Program
{

    
    static void Main(string[] args)
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        //string consider = "\nConsider the following prompt:\n";
        ThinkOf thinkOf = new ThinkOf();
        thinkOf.Thnk();
        //string inMind = "oi";
        //thinkOf._chosen;
        //string prompt = "";
        string prompt = thinkOf._chosen;


        ReflQuestions reflQuestions = new ReflQuestions();
        string[] questions = reflQuestions.questions;
        
    //     string[] questions = {
    //     "Why was this experience meaningful to you?",
    //     "Have you ever done anything like this before?",
    //     "How did you get started?",
    //     "How did you feel when it was complete?",
    //     "What made this time different than other times when you were not as successful?",
    //     "What is your favorite thing about this experience?",
    //     "What could you learn from this experience that applies to other situations?",
    //     "What did you learn about yourself through this experience?",
    //     "How can you keep this experience in mind in the future?"
    // };
    
    // Experience experience = new ReflectiveExperience(consider, prompt, questions);
    Experience experience = new ReflectiveExperience(prompt, questions);
    
    Console.WriteLine(prompt);
    Console.WriteLine("\n---When you have something in mind, press enter to continue---.\n");

     List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
        

    //experience.Start(); 
    }
    // {
    //     //Console.WriteLine("Hello Learning02 World!");

    //     Job job1 = new Job();
    //     job1._jobTitle = "Software Engineer";
    //     job1._company = "Microsoft";
    //     job1._startYear = 1990;
    //     job1._endYear = 2022;

    //     Job job2 = new Job();
    //     job2._jobTitle = "Manager";
    //     job2._company = "Apple";
    //     job2._startYear = 2022;
    //     job2._endYear = 2023;

    //     // Console.WriteLine(job1._company);
    //     // Console.WriteLine(job2._company);

    //     Resume myResume = new Resume();
    //     myResume._name = "Adamastor Cavalcante";

    //     myResume._jobs.Add(job1);
    //     myResume._jobs.Add(job2);

    //     myResume.Display();
    // }
}