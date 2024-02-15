
public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"[{_amountCompleted}/{_target}] {GetShortName()} - {GetDescription()}";
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $", Completed {_amountCompleted}/{_target} times";
    }
    public override bool IsChecklistGoal()
    {
        return true;
    }
    public override int GetTarget()
    {
        return _target;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}