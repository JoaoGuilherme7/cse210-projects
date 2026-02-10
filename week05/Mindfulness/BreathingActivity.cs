using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        base.SetName("Breathing Activity");
        base.SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focous on your breathing.");
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        base.AskSeconds();

        if (base._duration < 4)
        {
            Console.WriteLine("Time too short, let's do it for at least 4 seconds.");
            base._duration = 4;
        }

        Console.WriteLine();
        Console.WriteLine("GetReady...");
        base.ShowSpinner(5);

        int rest = base._duration % 10;
        int sections = base._duration / 10;

        if (rest > 0)
        {
            if (rest >= 4)
            {
                if (rest % 2 == 0)
                    this.StartActivity(rest / 2, rest / 2);
                else
                    this.StartActivity((int)rest / 2, (int)rest / 2 + 1);
            }
            else
            {
                if (rest % 2 == 0)
                    this.StartActivity(4 + (rest / 2), 6 + rest / 2);
                else
                    this.StartActivity(4 + ((int)rest / 2 + 1), 6 + ((int)rest / 2));

                sections--;
            }
        }

        for (int i = sections; i > 0; i--)
        {
            this.StartActivity();
        }

        Console.WriteLine();
        base.DisplayEndingMessage();
        Console.WriteLine();
    }

    private void StartActivity(int brIn = 4, int brOut = 6)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        base.ShowCountdown(brIn);
        Console.WriteLine();
        Console.Write("Breathe out...");
        base.ShowCountdown(brOut);
        Console.WriteLine();
    }
}