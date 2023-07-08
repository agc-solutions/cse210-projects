using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video {_title = "AirFryer2", _author = "Wallita", _lengthInSeconds = 30};
        v1._comments.Add(new Comment {_commenterName = "Peter", _commentary = "Amazing!!"});
        v1._comments.Add(new Comment {_commenterName = "Mary", _commentary = "The best of all!!"});
        v1._comments.Add(new Comment {_commenterName = "Jannet", _commentary = "I love it!!"});
        v1._comments.Add(new Comment {_commenterName = "Lucy", _commentary = "Wonderful!!"});
        videos.Add(v1);

        Video v2 = new Video {_title = "SmartPhone", _author = "Samsung", _lengthInSeconds = 20};
        v2._comments.Add(new Comment {_commenterName = "Richard", _commentary = "Could be better!!"});
        v2._comments.Add(new Comment {_commenterName = "Josie", _commentary = "I expected more!!"});
        v2._comments.Add(new Comment {_commenterName = "Wilma", _commentary = "I liked it!!"});
        v2._comments.Add(new Comment {_commenterName = "Walter", _commentary = "It is good."});
        videos.Add(v2);

        Video v3 = new Video {_title = "Tennis", _author = "Nike", _lengthInSeconds = 15};
        v3._comments.Add(new Comment {_commenterName = "Greg", _commentary = "It is good!!"});
        v3._comments.Add(new Comment {_commenterName = "Chris", _commentary = "It's a little hard."});
        v3._comments.Add(new Comment {_commenterName = "Mary", _commentary = "It is very ugly."});
        v3._comments.Add(new Comment {_commenterName = "Wallace", _commentary = "Is it for running?"});
        videos.Add(v3);

       


        Video v4 = new Video();
        v4._title = "Video Game";
        v4._author = "Sony";
        v4._lengthInSeconds = 25;
        v4._comments.Add(new Comment {_commenterName = "Joseph", _commentary = "Pretty good2."});
        v4._comments.Add(new Comment {_commenterName = "Emma", _commentary = "I loved."});
        videos.Add(v4);

        Video v5 = new Video();
        v5._title = "Wash Machine";
        v5._author = "LG";
        v5._lengthInSeconds = 40;
        
        Comment _comments5 = new Comment();
        _comments5._commenterName = "George";
        _comments5._commentary = "Nice.";
        Comment _comments9 = new Comment();
        _comments9._commenterName = "Steve";
        _comments9._commentary = "Matvelous.";
        v5._comments.Add(_comments5);
        v5._comments.Add(_comments9);
        
        videos.Add(v5);

        Video v6 = new Video();
        v6._title = "Compass";
        v6._author = "JEEP";
        v6._lengthInSeconds = 40;
        
        Comment _comments6 = new Comment();
        _comments6._commenterName = "Adam";
        _comments6._commentary = "Amazing.";
        v6._comments.Add(_comments6);
        videos.Add(v6);


        foreach (Video v in videos)
        {
            // Console.WriteLine($"\nTitle: {v._title}");
            // Console.WriteLine($"Author: {v._author}");
            // Console.WriteLine($"Length (seconds): {v._lengthInSeconds}");
            // Console.WriteLine($"Number of comments: {v.GetNumberOfComments()}");
            v.Display();
            foreach (Comment c in v._comments)
            {
                c.Display();
            }
            // foreach (Comment c in v._comments)
            // //foreach (Comment comments in v.comments)
            // {
            //     Console.WriteLine($"{c._commenterName}: {c._commentary}");
            //     //_comments.Display();
            // }

        }

        // Comment myteste = new Comment();
        // myteste.Display();
        // myteste.Display2();
    }
}