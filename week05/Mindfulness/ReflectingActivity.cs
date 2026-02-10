using System;

class ReflectingActivity : Activity
{

    private List<string> _questions = [ "Why was this experience meaningful to you?",
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"];
    private List<string> _prompts = ["Think of a time when you stood up for someone else.",
                                     "Think of a time when you did something really difficult.",
                                     "Think of a time when you helped someone in need.",
                                     "Think of a time when you did something truly selfless."];

    private List<string> _questionsMade = new List<string>();

    public ReflectingActivity() : base()
    {
        base.SetName("Reflecting Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        base.AskSeconds();

        Console.WriteLine();
        Console.WriteLine("GetReady...");
        base.ShowSpinner(5);
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        DisplayQuestions();
        Console.WriteLine();
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = new Random().Next(_prompts.Count);
        return this._prompts[index];
    }
    public string GetRandomQuestion()
    {
        if (this._questions.Count == 0)
        {
            this._questions = this._questionsMade;
            return "No more questions available. Question list reset.";
        }

        int index = new Random().Next(_questions.Count);
        string question = this._questions[index];

        this._questionsMade.Add(question);
        this._questions.RemoveAt(index);

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine(this.GetRandomPrompt());
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:");
        base.ShowCountdown(5);
        Console.WriteLine();

        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(base._duration);
        int thinkingTime = 10;

        while (now <= endTime)
        {
            Console.WriteLine();
            Console.WriteLine(this.GetRandomQuestion());
            base.ShowSpinner(thinkingTime);
            now = DateTime.Now;
        }
    }
}
