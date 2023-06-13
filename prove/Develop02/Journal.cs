public class Journal
{
    public static Entry _rndPpt = new Entry();
    //public List<string> _userThoughts = new List<string>();
    //public List<string> _rndPpt.StoreThoughts = new List<string>();
    //List<string> lista = _lista._userThoughts;
    //public list <string> _userThoughts = _rndPpt.StoreThoughts
    //string _userChoice;
    //string _csv;
    //string _txt;
    //public string _userThought;
    //StoreThoughts(_userThought);

    
    
    public void DisplayPrompt()
    {
        _rndPpt.teste();
    }
    public void DisplayEntries()
    {
        foreach(string line in _rndPpt._userThoughts)
        //foreach(string line in _userThoughts)
        
        {
            Console.WriteLine(line);
        }
    }
    public void LoadFromFile()
    {       
        Console.WriteLine("Type your filename: ");
        string _txt = Console.ReadLine();
        string content = File.ReadAllText(_txt);
        string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        foreach(string line in lines)
        {
            _rndPpt._userThoughts.Add(line);
            //_userThoughts.Add(line);
        }         
    }
    
    public void SaveToFile()
    {
        Console.WriteLine("Type your file name: ");

        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in _rndPpt._userThoughts)
            //foreach (string line in _userThoughts)
            {
                outputFile.WriteLine(line);
            }
        }
    } 

    // public void StoreThoughts(string _userThought)
    
    // {
    //    _userThoughts.Add(_userThought);
       
    //}
}