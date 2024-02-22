using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Video 1", "Creator 1", 300),
            new Video("Commercial 1", "Company 1", 400),
            new Video("Stream 1", "Streamer 1", 240)
        };

        videos[0].AddComment("Watcher 1", "Great video!");
        videos[0].AddComment("Watcher 2", "Very nice!");
        videos[1].AddComment("Watcher 3", "Interesting choice.");
        videos[2].AddComment("Watcher 4", "This taught me a lot!");

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}