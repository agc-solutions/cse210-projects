public class Activity2
{
    private string _activityName;
    private string _stdStartingMessage;
    private string _stdStartingQuestion;
    private int _duration;
    private string _description;
    private string _stdFinishingMessage;


    private string _Prompts;
    private string [] _questions;
    private string [] _thinkOf;
    

    public Activity2(string activityName, string stdStartingMessage, string stdStartingQuestion, int duration, string description, string stdFinishingMessage)
    {
        _activityName = activityName;
        _stdStartingMessage = stdStartingMessage;
        _stdStartingQuestion = stdStartingQuestion;
        _duration = duration;
        _description = description;
        _stdFinishingMessage = stdFinishingMessage;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetStdStartingMessage()
    {
        return _stdStartingMessage;
    }
    public string GetStdStartingQuestion()
    {
        return _stdStartingQuestion;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetStdFinishingMessage()
    {
        return _stdFinishingMessage;
    }

    public void Start()
    {
        Console.WriteLine(_thinkOf);
        foreach (string question in _questions) 
        {
            Console.WriteLine(question);
            Thread.Sleep(2000);
        }
    }

}















// {    
//     private string _activityName;
//     string _stdStartingMessage;
//     private string _stdStartingQuestion = "How long, in seconds, would you like for your section? ";
//     // int duration = 0;
//     // string _description = "";
//     // string _stdFinishingMessage = "";    
//     string choice = Console.ReadLine();
//     //private string _nAct ;

//     public void DisplayStdStartingMessage()
//     {
//         Console.Write($"Welcome to the {_activityName}.\n");
//     }
//     public Activity2(string activityName)
//     {
//         _activityName = activityName;
//     }

//     public string GetActivityName()
//     {
//         return _activityName;
//     }

//}