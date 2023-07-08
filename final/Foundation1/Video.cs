using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
    }
}







// {
//     public string _title { get; set; }
//     public string _author { get; set; }
//     public int _lengthInSeconds { get; set; }
//     public List<Comment> comments { get; } = new List<Comment>();

//     public int GetNumberOfComments()
//     {
//         return comments.Count;
//     }

    
// }