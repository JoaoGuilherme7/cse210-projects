using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int largest, number, smallest, sum = 0;
        Console.Write("Type a number to add to the list: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        largest = number;
        smallest = number;

        while (number != 0)
        {
            Console.Write("Type a number to add to the list: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            if (number > largest) largest = number;
            if (number > 0 && number < smallest) smallest = number;
        }

        numbers.RemoveAt(numbers.Count - 1);

        numbers.Sort();
        Console.WriteLine("Sorted Array: ");
        foreach (int n in numbers)
        {
            Console.WriteLine($"{n}");
            sum += n;
        }

        Console.WriteLine($"sum: {sum} ");
        Console.WriteLine($"Average: {(float)sum / numbers.Count} ");
        Console.WriteLine($"Largest number {largest}");

        if (smallest > 0) Console.WriteLine($"The smallest positive is : {smallest}");
        else Console.WriteLine("There's no positive numbers. ");
    }
}