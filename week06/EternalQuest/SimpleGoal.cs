class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        this._isComplete = false;
    }

    public override void RecordEvent()
    {
        this._isComplete = true;
    }

    public override bool IsComplete()
    {
        return this._isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[SimpleGoal] {this._shortName} - {this._description} ({this._points} points) Completed: {this._isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{this._shortName}|{this._description}|{this._points}|{this._isComplete}";
    }
}

