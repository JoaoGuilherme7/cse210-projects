using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity()
    {
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {this._name}.");
        Console.WriteLine(this._description);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        this.ShowSpinner(3);
        Console.WriteLine($"You have completed {this._duration} seconds of {this._name}.");
        this.ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string x = "|/-\\|/-\\";
        int index = 0;

        while (DateTime.Now < endTime)
        {
            if (index == 8) index = 0;
            Console.Write(x[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void SetName(string name)
    {
        this._name = name;
    }
    public void SetDescription(string description)
    {
        this._description = description;
    }
    public bool SetSeconds(int seconds, int min = 1, int max = 120)
    {
        if (seconds < min || seconds > max) return false;

        this._duration = seconds;
        return true;
    }
    protected void AskSeconds()
    {
        Console.Write("How Long, in seconds, would you like for this section?  ");
        int seconds = int.Parse(Console.ReadLine());
        while (!this.SetSeconds(seconds))
        {
            Console.Write("Invalid value for seconds. Type a valid value: ");
            seconds = int.Parse(Console.ReadLine());
        }
    }
}