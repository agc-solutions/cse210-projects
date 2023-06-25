public class ChecklistGoals : Goals
{
    //private ChecklistGoals;
    private int _numberOfTimes;
    private int _desiredAmount;
    private int _bonus;

    public void ChecklistGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int numberOfTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplish it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        _numberOfTimes = numberOfTimes;
        _desiredAmount = 0;
        _bonus = bonus;
    }
    public ChecklistGoals(string nameOfGoal, string description, int pointsAmount, int numberOfTimes, int bonus) : base (nameOfGoal, description, pointsAmount)
    {
        _numberOfTimes = numberOfTimes;
        _desiredAmount = 0;
        _bonus = bonus;
    }

     public ChecklistGoals(string nameOfGoal, string description, int pointsAmount, int desiredAmount, int numberOfTimes, int bonus) : base (nameOfGoal, description, pointsAmount)
    {
        _numberOfTimes = numberOfTimes;
        _desiredAmount = desiredAmount;
        _bonus = bonus;
    }

    public int GetNumberOfTimes()
    {
        return _numberOfTimes;
    }

    public int GetDesiredAmount()
    {
        return _desiredAmount;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetNumberOfTimes(int numberOfTimes)
    {
        _numberOfTimes = numberOfTimes;
    }

    public void SetDesiredAmount(int desiredAmount)
    {
        _desiredAmount = desiredAmount;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public void DesiredAmount()
    {
        _desiredAmount += 1;
    }


}