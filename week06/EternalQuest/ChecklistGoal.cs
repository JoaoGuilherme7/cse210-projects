class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted = 0) : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
        this._target = target;
        this._amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        this._amountCompleted++;
        if (IsComplete())
        {
            Console.WriteLine($"Bonus of {this._bonus} points achieved for {this._name}!");
            return this._points + this._bonus;
        }
        return this._points;
    }

    public override bool IsComplete()
    {
        return this._amountCompleted >= this._target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {this._name} ({this._description}) - ({this._amountCompleted} / {this._target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{this._name}|{this._description}|{this._points}|{this._bonus}|{this._target}|{this._amountCompleted}";
    }
}
