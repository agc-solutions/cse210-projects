public class ReflectionActivity : Activity2
{
    
    private string [] _questions;
    private string [] _thinkOf;

    public ReflectionActivity(string activityName, string stdStartingMessage, string _questions, int duration, string description, string[] thinkOf, string[] questions, string stdFinishingMessage)
        : base(activityName, stdStartingMessage, _questions, duration, description, stdFinishingMessage) {}
    // {}
    //    string[] _thinkOf = {
    //     "Think of a time when you stood up for someone else.",
    //     "Think of a time when you did something really difficult.",
    //     "Think of a time when you helped someone in need.",
    //     "Think of a time when you did something truly selfless."
    //    };

    //    //list<string> questions = new list<string>
    //    string[] _questions = new string[]
    //    {
    //     "Why was this experience meaningful to you?",
    //     "Have you ever done anything like this before?",
    //     "How did you get started?",
    //     "How did you feel when it was complete?",
    //     "What made this time different than other times when you were not as successful?",
    //     "What is your favorite thing about this experience?",
    //     "What could you learn from this experience that applies to other situations?",
    //     "What did you learn about yourself through this experience?",
    //     "How can you keep this experience in mind in the future?"
    //    };

    //    foreach (string question in _questions)
    //    {
    //     Console.Write(question + "");
    //    }
    // //}

    public new void Start()
    {
        Console.WriteLine(_thinkOf);
        foreach (string question in _questions) 
        {
            Console.Write("Reflecting... ");
            for (int i = 0; i < 10; i++) 
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine(question);
            Thread.Sleep(2000);
        }
    }
}