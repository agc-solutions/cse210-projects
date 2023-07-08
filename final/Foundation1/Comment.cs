public class Comment
// {
//     public string _commenterName { get; set; }
//     public string _commentary { get; set; }
// }

// OR

{
    public string _commenterName; //{ get; set; } If I use the commands inside the curly braces, I don't need to write the code from line 7, only these two lines are enough. ahead.
    public string _commentary; //{ get; set; }  In other words, the command { get; set; } replaces, in this case, lines 17 onwards


    // public string GetCommenterName()
    // {
    //     return _commenterName;
    // }
    
    // public void SetCommenterName(string commenterName)
    // {
    //     _commenterName = commenterName;
    // }

    public void Display()
    {
       Console.WriteLine($"{_commenterName}: {_commentary}");              
    }

    
} 