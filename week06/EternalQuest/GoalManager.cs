class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void Start()
    {
        DisplayMenu();
        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice != 5)
        {
            if (choice == 1)
            {
                ListGoalNames();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the index of the goal to record an event: ");
                int goalIndex = int.Parse(Console.ReadLine());
                RecordEvent(goalIndex);
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
        }



    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {this._score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in this._goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in this._goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal(Goal goal)
    {
        this._goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < this._goals.Count)
        {
            this._goals[goalIndex].RecordEvent();
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Goals loaded.");
    }

    private void DisplayGoalOptions()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. List Goals");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Exit");
    }
}