public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isEternal;


    public Goal(string name, string description, int points, bool eternal = false)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isEternal = eternal;
    }

    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetEternal()
    {
        return _isEternal;
    }

    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}";
    }
    public virtual bool IsChecklistGoal()
    {
        return false;
    }
    public virtual int GetTarget()
    {
        return -1;
    }
    public virtual int GetBonus()
    {
        return -1;
    }
}