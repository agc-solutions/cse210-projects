public abstract class Goals
{
    GoalsGenetator _gen = new GoalsGenetator();
    protected string _nameOfGoal;
    protected string _description;
    protected int _pointsAmount;
    protected List<string> _listOfGoals;
    protected bool _conclusion;
    
    public void Goal()
    {
        _gen.Goals();
    }
    

    public Goals(string nameOfGoal, string description, int _pointsAmount)
    {
        int pointsAmount = 0;
        //string description = "";
        _nameOfGoal = nameOfGoal;
        _description = description;
        _pointsAmount = pointsAmount;
        _conclusion = false;
    }

    public Goals(string nameOfGoal, string description, int _pointsAmount, bool _conclusion)
    {
        _nameOfGoal = nameOfGoal;
        _description = description;
        //_pointsAmount = pointsAmount;
       // _conclusion = conclusion;

    }

    public string GetNameOfGoal()
    {
        return _nameOfGoal;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPointsAmount()
    {
        return _pointsAmount;
    }

    public void SetNameOfGoal(string nameOfGoal)
    {
        _nameOfGoal = nameOfGoal;
    }

     public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPointsAmount(int pointsAmount)
    {
        _pointsAmount = pointsAmount;
    }
    //public abstract 

    public virtual bool GetConclusion()
    {
        return _conclusion;
    }
    public virtual void SetConclusion(bool conclusion)
    {
        _conclusion = conclusion;
    }

    public virtual string Display(){
    return $"[{(GetConclusion()?'X':' ')}] {GetNameOfGoal()} ({GetDescription()})" ;
  }


}