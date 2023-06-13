public class ThinkOf
{
    public string _chosen;
    public void Thnk()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",         
        };    
        // Declare a random
        Random rnd = new Random();
        //Make random take a value inside of array by the random generated in the index
        int r = rnd.Next(prompts.Length);
        //Now you can get your prompt
        _chosen = (prompts[r]);

        //Console.WriteLine("---When you have something in mind, press enter to continue---.\n");
    }
    
}