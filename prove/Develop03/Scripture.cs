using System;
public class Scripture 
{
    // public string References refes = new References();
    // refes._book = "Alma";
    // refes._chapter = 37;
    // refes._verse = 37;

    //public static Scripture _userChoice = new Scripture();
    //private _scripture;
    private int _reference;
    private string _text;
    public string _scrpt = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
    public void scrptr()
    {
        string scrpt = _scrpt;
        string[] words = scrpt.Split(' '); //split the scrpt in words
        Random rnd = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            if (rnd.Next(2) == 0) 
            
            {
                words[i] = new string('_', words[i].Length); //replace words with underscores
            }
        }
        string newScrpt = String.Join(" ", words); //put the words back together in a script
    Console.WriteLine(newScrpt);




    // public void LoadFromFile()
    // {       
    //     Console.WriteLine("Type your filename: ");
    //     string _txt = Console.ReadLine();
    //     string content = File.ReadAllText(_txt);
    //     string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
    //     foreach(string line in lines)
    //     {
    //        // _rndPpt._userThoughts.Add(line);
    //     }         
    // }

    }
}