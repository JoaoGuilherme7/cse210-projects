using System;
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.
class Program
{
    static void Main(string[] args)
    {
        string name;
        int number, squared;
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program");
    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"Brother {name}, the square of your number is {square}.");
    }

    static string PromptUserName(){
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int n){
        return n*n;
    }
}