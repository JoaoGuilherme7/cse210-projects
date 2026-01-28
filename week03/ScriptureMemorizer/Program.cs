// I mplemented a way to get a random scripture from an array of scriptures and ask the user if he wants to try one more scripture.
// If all the scriptures were already memorized, the user is alerted and the program ends.

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

        string quit = "";
        while (!string.Equals(quit.ToLower(), "quit"))
        {
            if (scriptures.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Congratulations! It seems like you memorized all scripures available. The program will end.");
                return;
            }

            int randonNumber = new Random().Next(0, scriptures.Count);
            Scripture scripture = scriptures[randonNumber];

            while (!string.Equals(quit.ToLower(), "quit"))
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    scriptures.Remove(scripture);
                    break;
                }

                Console.Write("Press Enter hide more words or quit to finish: ");
                quit = Console.ReadLine();
                if(!string.Equals(quit.ToLower(), "quit"))
                    scripture.HideRandonWords(2);
            }
            Console.Write("Press Enter to try another Scripture or quit to finish: ");
            quit = Console.ReadLine();
        }
    }

}