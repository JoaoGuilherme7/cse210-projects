//Made the functionality of ensuring there'll be no repeated questions in the ReflectingActivity.
class Program
{
    static void Main(string[] args)
    {
        int input = 0;

        while (true)
        {
            ShowMenu();
            input = int.Parse(Console.ReadLine());
            if (input == 4) return;
            if (input < 1 || input > 3)
            {
                Console.WriteLine("Invalid Option...");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else HandleChoice(input);
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start Breathing Activity ");
        Console.WriteLine("2. Start Reflecting Activity ");
        Console.WriteLine("3. Start Listing Activity ");
        Console.WriteLine("4. Quit ");

        Console.Write("Select a choice from the menu: ");
    }

    static void HandleChoice(int choice)
    {
        int breathing = 1;
        int reflecting = 2;
        int listing = 3;

        if      (choice == breathing)   new BreathingActivity().Run();
        else if (choice == reflecting)  new ReflectingActivity().Run();
        else if (choice == listing)     new ListingActivity().Run();
    }
}