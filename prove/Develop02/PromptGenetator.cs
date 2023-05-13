public class PromptGenerator
{
    //private object ppt;
    // public void PromptGen()
    // {
    //string[] prompts = 
    public List<string> _prompts = new List<string>()
    {
        "What was the best part is my day?",
        "How did I see the hand of the Lord in my life today?",
        "Did I do something nice for someone today?",
        "Did I do something today that I keep doing?",
        "Did I do something today that I stop doing?",
        "Did I do something today that I've never done before?",
        "Did I feel something today that I've never felt before?",
    };    
    public void PromptGen()
    {
        // Declare a random
        Random rnd = new Random();
        //Make random take a value inside of array by the random generated in the index
        int r = rnd.Next(_prompts.Count);
        //Now you can get your prompt
        //string ppt = (prompts[r]);
        string chosenPrompt = (_prompts[r]);
        
        //var chosenPrompt = ((string)prompts[r]);
        //Console.WriteLine(prompts[r]);
        //Console.WriteLine(chosenPrompt);
       
        // string str = $"{ppt}";
        // Console.WriteLine(str)
        //public List<Entry> _entries = new List<Entry>();
              
            // Entry entry = new Entry();
            // entry._chosenPrompt = chosenPrompt;
            Console.WriteLine(chosenPrompt);

    }   
 
       
    // public void rd()
    // {
    //     Convert.ToString(ppt);
    // }
    
}   
