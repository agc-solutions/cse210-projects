public class PromptGenerator
{
    
    public string[] prompts = {
        "What was the best part is my day?",
        "Did I do something nice for someone today?",
        "Did I do something today that I keep doing?",
        "Did I do something today that I stop doing?",
        "Did I do something today that I've never done before?",
        "Did I feel something today that I've never felt before?",

    };
    // Declare a random
    Random phrase = new Random();
    //Do the random take a value inside of array by random gerated in index
    int r = phrase.Next(prompts.Length);
    //Now you can get your prompt
    var sortedPrompt = ((string)prompts[r]);
    
    public void Display()
    {
        Console.WriteLine(prompts[r]);
    }
    
    
}