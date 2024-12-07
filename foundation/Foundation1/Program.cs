using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creates videos
        Video video1 = new Video { Title = "Understanding C#", Author = "Code Guru", LengthInSeconds = 600 };
        Video video2 = new Video { Title = "Learn .NET in 10 Minutes", Author = "Tech Wizard", LengthInSeconds = 720 };
        Video video3 = new Video { Title = "Top 5 Programming Tips", Author = "Dev Pro", LengthInSeconds = 300 };

        // Adds comments to video1
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "I learned a lot from this."));
        video1.AddComment(new Comment("Charlie", "Great explanation!"));

        // Adds comments to video2
        video2.AddComment(new Comment("Dave", "I love this channel."));
        video2.AddComment(new Comment("Eve", "Thanks for the quick tips."));
        video2.AddComment(new Comment("Frank", "Perfect for beginners."));

        // Adds comments to video3
        video3.AddComment(new Comment("Grace", "Short and to the point."));
        video3.AddComment(new Comment("Hank", "Loved the examples."));
        video3.AddComment(new Comment("Ivy", "Please make more like this!"));

        // Creates a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displays videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}