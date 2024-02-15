
public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"Name: {GetShortName()}, Description: {GetDescription()}, Points: {GetPoints()}, Completion Rate: {(IsComplete() ? "Completed" : "Not Completed")}";
    }
}