// using System;
// // using System.IO;
// // using System.Collections.Generic;


//public class Journal2
//{
    // public static Entry2 _rndPpt = new Entry2();
    // //public List<string> _userThoughts = new List<string>();
    // //public List<Entry> _response = new List<Entry>();
    // public List<Entry> _entry = new List<Entry>();
    // //string _userThought;
    // //StoreThoughts(_userThought);

    // // public void StoreThoughts(string _userThought)    
    // // {
    // //     foreach (Entry entry in _userThoughts)
    // //     {
    // //         _rndPpt._userThoughts.Add(_userThought);
    // //         _userThoughts.Add(_userThought);
    // // //     // lista.Add(_userThought);
    // // //     //_abc._userThoughts.Add(_userThought);
    // //     }
    // // }


    // // public void teste()
    // // {
    // //     foreach (Entry entry in _userThoughts)
    // //     {
    // //         //entry.teste();
    // //         //StoreThoughts(_userThought);
    // //         entry.StoreThoughts(_userThought);
    // //     }
    // // }

    // public void Display()
    // {
    //     //foreach (Entry entry in _response)
    //     foreach (Entry entry in _entry)
    //     {
    //         entry.Display();
    //     }
    // }
  
    //  public void Save(Entry entry)
    // {
    //     //_response.Add(entry);
    //     _entry.Add(entry);
    // }
    

    
    
    // public void DisplayPrompt()
    // {
    //     _rndPpt.teste();
    //     //teste();
    // }
    // public void DisplayEntries()
    // {
    //     //foreach(string line in _rndPpt._response)
    //     foreach(string line in _rndPpt._entry)
    //     //foreach(string line in _userThoughts)
        
    //     {
    //         Console.WriteLine(line);
    //     }
    // }

    // public void LoadFromFile()
    // {       
    //     Console.WriteLine("Type your filename: ");
    //     string _txt = Console.ReadLine();
    //     string content = File.ReadAllText(_txt);
    //     string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
    //     foreach(string line in lines)
    //     {
    //         //_rndPpt._response.Add(line);
    //         //_userThoughts.Add(line);
    //         Console.WriteLine(line);
    //     }         
    // }
    
    // public void SaveToFile()
    // {
    //     Console.WriteLine("Type your file name: ");

    //     string filename = Console.ReadLine();
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         //foreach (string line in _rndPpt._response)
    //         //foreach (string line in _userThoughts)
    //         //foreach (Entry entry in _response)
    //         foreach (Entry entry in _entry)
    //         {
    //             //outputFile.WriteLine(line);
    //             //outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} \n {entry._reponse}");
    //             outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} \n {entry._entry}");
    //         }
    //     }
    // } 
//}