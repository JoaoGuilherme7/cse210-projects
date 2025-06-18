using System;

class ListingActivity : Activity
{

    private int _count = 0;
    private List<string> _prompts = [   "Who are people that you appreciate?",
                                        "What are personal strengths of yours?",
                                        "Who are people that you have helped this week?",
                                        "When have you felt the Holy Ghost this month?",
                                        "Who are some of your personal heroes?"];

    public ListingActivity() : base()
    {
        base.SetName("Listing Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        base.AskSeconds();
        Console.WriteLine();
        Console.WriteLine("GetReady...");
        base.ShowSpinner(5);
        this.GetRandomPrompt();
        Console.WriteLine();
        Console.Write("You may begin in:");
        base.ShowCountdown(5);
        this.GetListFromUser();
        base.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        int index = new Random().Next(_prompts.Count);
        Console.WriteLine(this._prompts[index]);
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = [];

        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        while (DateTime.Now <= endTime)
        {
            Console.WriteLine("> ");
            answers.Add(Console.ReadLine());
            this._count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {this._count} items.");
        Console.WriteLine();
        return answers;
    }
}
