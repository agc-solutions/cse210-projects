public class PromptGenerator
{
    public string _chosen;
    public void PromptGen()
    {
        string[] prompts = {
            "What was the best part is my day?",
            "How did I see the hand of the Lord in my life today?",
            "Did I do something nice for someone today?",
            "Did I do something today that I keep doing?",
            "Did I do something today that I stop doing?",
            "Did I do something today that I've never done before?",
            "Did I feel something today that I've never felt before?",
        };    
        // Declare a random
        Random rnd = new Random();
        //Make random take a value inside of array by the random generated in the index
        int r = rnd.Next(prompts.Length);
        //Now you can get your prompt
        string chosenPrompt = (prompts[r]);
        _chosen = ($"{chosenPrompt}");
        //var chosenPrompt = ((string)prompts[r]);
        //Console.WriteLine(prompts[r]);
        Console.WriteLine(chosenPrompt);
    }       
}
