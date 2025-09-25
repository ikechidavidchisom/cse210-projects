using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Jollof Rice", "NaijaChef", 420);
        video1.AddComment(new Comment("Ada", "This recipe is fire 🔥"));
        video1.AddComment(new Comment("Tunde", "Tried it and loved it!"));
        video1.AddComment(new Comment("Chioma", "Can you do Egusi soup next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Lagos Drone Tour", "CityExplorer", 300);
        video2.AddComment(new Comment("Kemi", "Wow, Lagos looks stunning!"));
        video2.AddComment(new Comment("John", "I miss home 😢"));
        video2.AddComment(new Comment("Fatima", "Great editing!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video3.AddComment(new Comment("Alex", "Super helpful, thanks!"));
        video3.AddComment(new Comment("Nina", "Can you do Python next?"));
        video3.AddComment(new Comment("Sam", "Clear and concise."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
