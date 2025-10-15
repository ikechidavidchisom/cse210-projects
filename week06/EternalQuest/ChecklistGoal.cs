public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        return _currentCount == _targetCount ? GetPoints() + _bonus : GetPoints();
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetailsString() =>
        $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_targetCount}|{_currentCount}";
}
