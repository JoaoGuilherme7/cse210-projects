using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        

        manager.DisplayPlayerInfo();
        manager.ListGoalNames();
        manager.ListGoalDetails();
    }

    

}