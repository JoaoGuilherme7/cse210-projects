class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
        this._amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        this._amountCompleted++;
        if (IsComplete())
        {
            Console.WriteLine($"Bonus of {this._bonus} points achieved for {this._shortName}!");
        }
    }

    public override bool IsComplete()
    {
        return this._amountCompleted >= this._target;
    }

    public override string GetDetailsString()
    {
        return $"[ChecklistGoal] {this._shortName} - {this._description} ({this._points} points per event, Bonus: {this._bonus} after {this._target} completions) Progress: {this._amountCompleted}/{this._target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{this._shortName}|{this._description}|{this._points}|{this._target}|{this._bonus}|{this._amountCompleted}";
    }
}
