class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        this._isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        this._isComplete = true;
        Console.WriteLine("Points earned: " + this._points);
        return this._points;
    }

    public override bool IsComplete()
    {
        return this._isComplete;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {this._name} ({this._description})";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{this._name}|{this._description}|{this._points}|{this._isComplete}";
    }
}

