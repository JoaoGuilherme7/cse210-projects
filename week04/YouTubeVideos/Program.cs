using System;

class Program
{
    static void Main(string[] args)
    {        
        Video video1 = new Video("How to start on Programming", "Alice", 300);
        video1.AddComment(new Comment("Bob", "Great video!"));
        video1.AddComment(new Comment("Charlie", "Very informative."));
        video1.AddComment(new Comment("Dave", "I learned a lot."));

        Video video2 = new Video("C# Basics", "John", 450);
        video2.AddComment(new Comment("Frank", "Thanks for the tutorial!"));
        video2.AddComment(new Comment("Grace", "Can you cover more advanced topics?"));
        video2.AddComment(new Comment("Hank", "This was very helpful, thanks!"));

        Video video3 = new Video("Object-Oriented Programming", "Charles", 600);
        video3.AddComment(new Comment("Jack", "I love OOP!"));
        video3.AddComment(new Comment("Karen", "This is a great introduction to OOP"));
        video3.AddComment(new Comment("Leo", "Can you explain inheritance in more detail?"));
        video3.AddComment(new Comment("Mia", "Thanks for the clear explanations!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.QuantityOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}