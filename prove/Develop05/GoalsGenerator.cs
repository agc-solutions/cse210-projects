using System.IO;
public class GoalsGenetator
{
    List<Goals> _goals = new List<Goals>();
    public void Goals()
    {
        int inputPoints = 0;
        Console.Write("What is the name of your goal? ");
        string nameOfGoal = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is amount of points associated with this goal? ");
        string userPoints = Console.ReadLine();
        inputPoints = int.Parse(userPoints);

        Console.WriteLine("The goals are:");

        // // // // for (int i = 0; i < _goals.Count(); i++)
        // // // // {
        // // // //     Console.WriteLine($"{i + 1}. {_goals[i]}");
        // // // //     //string _theGoal = ($"{i + 1}. [ ] {nameOfGoal} ({description})");
        // // // //     //Console.WriteLine = ($"{i + 1}. [ ] {nameOfGoal} ({description})");
        // // // // }

        // // // // //string _theGoal = ($"\nOlá: [ ] {nameOfGoal} ({description})");
        // // // // //Console.WriteLine(_theGoal);
        // // // // Console.WriteLine(_goals);
        //Console.WriteLine($"\nOlá: [ ] {nameOfGoal} ({description})");
    }

    private void AddGoals(Goals goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Goal created!");
    }

    public void List()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
            //Console.WriteLine($"{i + 1}.Goals()");
            //Console.WriteLine($"{i + 1}. {_theGoal}");
            //string _theGoal = ($"\nOlá: [ ] {nameOfGoal} ({description})");
        //Console.WriteLine(_theGoal);
        }
    }
}