public class ListingActivity : Activity2
{
    private string[] _prompts;
    private List<string> _userEntries;
    public string _chosen;
    private string[] chosenPrompt;
    public ListingActivity(string activityName, string stdStartingMessage, string stdStartingQuestion, int duration, string description, string [] prompts, string stdFinishingMessage)
        : base(activityName, stdStartingMessage, stdStartingQuestion, duration, description, stdFinishingMessage)
    {}
    // private static void Prompt()
    // {
        private string[] _Lprompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };    
        // Declare a random
        public void DisplayPrompt()
        {
        Random rnd = new Random();
        //Make random take a value inside of array by the random generated in the index
        int r = rnd.Next(_prompts.Length);
        //Now you can get your prompt
        string chosenPrompt = (_prompts[r]);
        // _chosen = ($"{chosenPrompt}");
        // Console.WriteLine(chosenPrompt);
        Thread.Sleep(2000);


   


    //}   


    }


}