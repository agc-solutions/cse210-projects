// public class TypeOfGoal
// {
//     List<Goals> _goals = new List<Goals>();
    
//     public void CreateGoal()
//     {
//         Console.WriteLine("\nThe types of goals are:");
//         Console.WriteLine("\nA. Simple Goal. \nB. Eternal Goal. \nC. Checklist Goal.");
//         Console.Write("\nWhich type of goal would you like to create? ");
//         string inputType = Console.ReadLine();
//         do
//         {
//             if (inputType.ToUpper() == "A") 
//             {
//                 SimpleGoals simple = new SimpleGoals();
//                 AddGoals(simple);
//             }

//             if (inputType.ToUpper() == "B")
//             {
//                 EternalGoals eternal = new EternalGoals();
//                 AddGoals(eternal);            
//             }

//             if (inputType.ToUpper() == "C")
//             {
//                 ChecklistGoals checklist = new ChecklistGoals();
//                 AddGoals(checklist);            
//             }
//         } while (inputType == "A" || inputType == "B" || inputType == "C");

//     }

//     private void AddGoals(Goals goal)
//     {
//         _goals.Add(goal);
//         Console.WriteLine("Goal created!");
//     }

//     public void List()
//     {
//         Console.WriteLine("The goals are:");
//         for (int i = 0; i < _goals.Count(); i++)
//         {
//             Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
//         }
//     }
// }