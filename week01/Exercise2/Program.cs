using System;

class Program
{
    static void Main(string[] args)
    {
        string letter, message;
        float grade;

        Console.Write("Enter your grade: ");
        grade = float.Parse(Console.ReadLine());

        if      (grade >= 90)   letter = "A";
        else if (grade >= 80)   letter = "B";
        else if (grade >= 70)   letter = "C";
        else if (grade >= 60)   letter = "D";
        else                    letter = "F";

        if (grade >= 70)    message = "Congratulations! You passed the course.";
        else                message = "Sorry, you failed the course. Keep trying, I believe in you!";

        if (grade <= 93 && letter != "F")
            if      (grade % 10 >= 7) letter += "+";
            else if (grade % 10 <= 3) letter += "-";


        Console.WriteLine(message);
        Console.WriteLine($"Your grade is: {letter}");
    }
}