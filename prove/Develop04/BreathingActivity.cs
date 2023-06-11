public class BreathingActivity : Activity2
{
    private string _messages;
    int duration = 0;
    //private List<string> _messages;

    public BreathingActivity(string activityName, string stdStartingMessage, string stdStartingQuestion, int duration, string description, string DisplayMessages, string stdFinishingMessage)
        : base(activityName, stdStartingMessage, stdStartingQuestion, duration, description, stdFinishingMessage){}
    
        //_messages = messages;
    public void DisplayMessages(int duration)
        {
            // Console.Write("\nGet ready...");
            // for (int i = 5; i > 0; i--)
            // {
            //     //Console.Write($"{i}...");
            //     Console.Write(i);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }
            Console.WriteLine("\nSTART!");
            int seconds = 0;
            do
            {
                Console.Write("\nBreathe in...");
                for (int i = 5; i > 0; i--)
                {
                    //Console.Write($"{i}...");
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.Write("\nNow breathe out...");
                for (int i = 5; i > 0; i--)
                {
                    //Console.Write($"{i}...");
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();

                seconds+=10;
                }while (seconds < duration);
                // Console.WriteLine($"\n\nWell done! \nYou have completed abother {duration} seconds of the Breathing Activity.");
                // Console.ReadLine();
        }
}
    