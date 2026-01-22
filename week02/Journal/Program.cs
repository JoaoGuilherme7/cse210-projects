using System;

class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int choice = 0;

        while (choice != 5)
        {
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: j.AddEntry(GetEntry()); break;
                case 2: j.Display(); break;
                case 3: j.LoadFromFile(AskFIleName()); break;
                case 4: j.SaveToFile(AskFIleName()); break;
                case 5: break;
            }            
        }
    }

    public static Entry GetEntry()
    {
        PromptGenerator p = new PromptGenerator();
        string prompt = p.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        return new Entry(prompt, response);
    }

    public static string AskFIleName()
    {
        Console.Write("What's the file name?");
        return Console.ReadLine();
    }
}