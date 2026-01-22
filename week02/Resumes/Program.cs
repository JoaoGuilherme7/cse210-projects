using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Console.Write("Resume Owner: ");
        string name = Console.ReadLine();
        Resume resume = new Resume(name);

        Console.WriteLine("Enter job details. Type '0' in the 'job title' to finish.");

        do
        {
            Console.WriteLine("-------------------------");

            Console.Write("Enter job title: ");
            string jobTitle = Console.ReadLine();
            if (string.Equals(jobTitle, "0")) break;

            Console.Write("Enter company name: ");
            string company = Console.ReadLine();

            Console.Write("Enter start year: ");
            int startYear = int.Parse(Console.ReadLine());

            Console.Write("Enter end year: ");
            int endYear = int.Parse(Console.ReadLine());

            Job job = new Job(jobTitle, company, startYear, endYear);
            resume.AddJob(job);
        } while (true);
        Console.WriteLine("\n--------------------------");
        Console.WriteLine("Resume:");
        resume.Display();
    }
}