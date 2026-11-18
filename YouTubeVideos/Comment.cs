
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold your videos
        List<Video> videos = new List<Video>();

        // 1. Create Video 1 and add its comments
        Video vid1 = new Video("C# Abstraction Tutorial", "Code Master", 300);
        vid1.AddComment(new Comment("Alice", "Super clear explanation!"));
        vid1.AddComment(new Comment("Bob", "Helped me pass my quiz. Thanks!"));
        videos.Add(vid1);

        // 2. Create Video 2 and add its comments
        Video vid2 = new Video("Object-Oriented Programming in C#", "Tech Academy", 450);
        vid2.AddComment(new Comment("Charlie", "Great code examples!"));
        vid2.AddComment(new Comment("Diana", "This made classes click for me."));
        vid2.AddComment(new Comment("Ethan", "Subscribed!"));
        videos.Add(vid2);

        // 3. Create Video 3 and add its comments
        Video vid3 = new Video("C# Lists and Collections", "Code Master", 600);
        vid3.AddComment(new Comment("Fiona", "Very helpful, thanks for sharing."));
        vid3.AddComment(new Comment("George", "Could you do a part two?"));
        videos.Add(vid3);

        // Loop through all videos and display their details and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}