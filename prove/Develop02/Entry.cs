public class Entry
{
    public static PromptGenerator _pptG = new PromptGenerator();
    public static Journal _abc = new Journal();
    List<string> lista = _abc._userThoughts;
    public List<string> _userThoughts = new List<string>();
    string _userThought;
       
    public void teste()
    {
        string response = "";
        _pptG.PromptGen();
        response = Console.ReadLine();
                
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        int NewLine = _userThoughts.Count +1; 
        //int NewLine = lista.Count +1;
        //int NewLine = _abc._userThoughts.Count +1;   

        _userThought = ($" Date: {date} - Prompt: {_pptG._chosen} \n{response} ");
        StoreThoughts(_userThought);
    }

    public void StoreThoughts(string _userThought)
    {
        _userThoughts.Add(_userThought);
        // lista.Add(_userThought);
        // abc._userThoughts.Add(_userThought);
    }
        
    // public void ReadFromFile()
    // {
    //     List<Write> newThoughts = ReadFromFile();
    //     foreach (Write t in newThoughts)
    //     {
    //         Console.WriteLine(t._thoughts);
    //     }
    //     static List<Write> ReadFromFile()
    //     {
    //         List<Write> thoughts = new List<Write>();
    //         string filename = "thoughts.txt";
    //         string[] lines = System.IO.File.ReadAllLines(filename);
    //         foreach (string line in lines)
    //         {
    //             string[] parts = line.Split(",");
    //             //Console.WriteLine(line);
    //         }

    //         return thoughts;
    //     } 
    // }
}