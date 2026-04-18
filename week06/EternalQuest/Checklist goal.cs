public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {   // target = how many times to complete, bonus = extra points for completing target
        _target = target;
        _count = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _count++;                       // ← increment FIRST

        if (_count < _target)
        {
            return _points;             // regular points
        }
        else
        {
            _isComplete = true;         // ← mark goal done
            return _points + _bonus;    // ← bonus on the final count
        }
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_shortDescription}) -- Currently completed: {_count}/{_target}";
    }
}
