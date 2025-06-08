using System;

class Program
{
    static void Main(string[] args)
    {


        List<Scripture> scriptures = new List<Scripture> {
            new Scripture(new Reference("John",3,16), "Porque Deus amou o mundo de tal maneira que deu seu filho unigênito para que todo aquele que nele crer não pereça, mas tenha vida eterna."),

            new Scripture(new Reference("Proverbs",3,5,6), "Trust in the Lord with all thine heart and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths."),

            new Scripture(new Reference("Isaiah",41,10), "Fear not, for I am with you; be not dismayed, for I am your God; I will strengthen you, I will help you, I will uphold you with my righteous right hand.")
        };

        int randonNumber = new Random().Next(0, scriptures.Count);

        Scripture scripture = scriptures[randonNumber];

        string quit = "";
        while (!string.Equals(quit.ToLower(), "quit"))
        {
            if (scripture.IsCompletelyHidden()) return;
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }

            quit = Console.ReadLine();
            scripture.HideRandonWords(3);
        }

    }
}