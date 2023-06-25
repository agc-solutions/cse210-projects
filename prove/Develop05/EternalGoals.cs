public class EternalGoals : Goals
{
    private int _points;
    public EternalGoals(string nameOfGoal, string description, int pointsAmount) : base (nameOfGoal, description, pointsAmount)
    {

    }
    
    public override bool GetConclusion()
    {
        return false;
    }
    public override void SetConclusion(bool conclusion)
    {
        _conclusion = false;
    }
    //public override int 



}