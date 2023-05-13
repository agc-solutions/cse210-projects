public class Entry
{
    public static PromptGenerator _pptG = new PromptGenerator();
    //public List<string> _ppts = new List<string>;
    public List<string> _userThoughts = new List<string>();
    string _userThought;
    public string _chosenPrompt;
    public string _date;
    public string _reponse;
    public void teste()
    {
        string response = "";
        // PromptGenerator myPromptGenerator = new PromptGenerator();
        _pptG.PromptGen();
        response = Console.ReadLine();

        
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        int NewLine = _userThoughts.Count +1;


        // Entry entry = new Entry();
        // entry._dateTime = date;
        // entry._chosenPrompt = _chosenPrompt;
        // entry._message = response;
        // _entries.Add(entry);
        Console.WriteLine(_chosenPrompt);

                
        _userThought = ($" Date: {date} - Prompt: {_chosenPrompt} \n{response} ");
        StoreThoughts(_userThought);
    }

    public void StoreThoughts(string _userThought)
    {
        _userThoughts.Add(_userThought);
    }
        
    public void ReadFromFile()
    {
        List<Write> newThoughts = ReadFromFile();
        foreach (Write t in newThoughts)
        {
            Console.WriteLine(t._thoughts);
        }
        static List<Write> ReadFromFile()
        {
            List<Write> thoughts = new List<Write>();
            string filename = "thoughts.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                //Console.WriteLine(line);
            }

            return thoughts;
        } 
    }
}