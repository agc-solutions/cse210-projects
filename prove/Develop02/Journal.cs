using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{   
   public static PromptGenerator _pptG = new PromptGenerator();
   public static Entry entry1 = new Entry();
   string date = DateTime.Now.ToShortDateString();
   public List<Entry> entries = new List<Entry>();

   public void NewEntry(string prompt)
   {
    Console.WriteLine(prompt);
    string response = Console.ReadLine();
    Entry entry = new Entry { _prompt = prompt, _response = response, _date = date};
    entries.Add(entry);
   }

   public void DisplayPrompt()
   {
    _pptG.PromptGen();
    string response = "";    
    response = Console.ReadLine();
    //      OR
    // string response = Console.ReadLine();
    Entry entry = new Entry { _prompt = _pptG._chosen, _response = response, _date = date};
    entries.Add(entry);
   }
   public void DisplayEntries()
   {
    foreach (Entry entry in entries)
    {
        Console.WriteLine($"Date: {entry._date}");
        Console.WriteLine($"Prompt: {entry._prompt}");
        Console.WriteLine($"Response: {entry._response}");
        Console.WriteLine();        
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
            Console.WriteLine(line);
        }         
    }
   public void SaveToFile()
    {
        Console.WriteLine("Type your file name: ");

        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {            
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} \n {entry._response}");
            }
        }
    } 
}