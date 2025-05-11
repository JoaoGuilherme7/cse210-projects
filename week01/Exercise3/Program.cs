using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "1";
        int magic, number, attempts;

        while (again == "1")
        {
            Console.Write("What is the magic number? ");
            magic = int.Parse(Console.ReadLine());
            number = magic + 1;
            attempts = 0;

            while (number != magic)
            {
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                if      (number > magic)    Console.WriteLine("Lower");
                else if (number < magic)    Console.WriteLine("Higher");

                attempts++;
            }
            Console.WriteLine($"Congratulations, you made it in {attempts} attempts.");
            Console.Write("Type 1 to play again: ");
            again = Console.ReadLine();
        }
    }
}