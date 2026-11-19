using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video vid1 = new Video("C# Abstraction Tutorial", "Code Master", 300);
        vid1.AddComment(new Comment("Alice", "Super clear explanation!"));
        vid1.AddComment(new Comment("Bob", "Helped me pass my quiz. Thanks!"));
        vid1.AddComment(new Comment("Charlie", "Very well structured."));
        videos.Add(vid1);

        // Video 2
        Video vid2 = new Video("Object-Oriented Programming in C#", "Tech Academy", 450);
        vid2.AddComment(new Comment("Diana", "This made classes click for me."));
        vid2.AddComment(new Comment("Ethan", "Subscribed!"));
        vid2.AddComment(new Comment("Fiona", "Awesome examples."));
        videos.Add(vid2);

        // Video 3
        Video vid3 = new Video("C# Lists and Collections", "Code Master", 600);
        vid3.AddComment(new Comment("George", "Could you do a part two?"));
        vid3.AddComment(new Comment("Hannah", "Saved my project!"));
        vid3.AddComment(new Comment("Ian", "Clear and straight to the point."));
        videos.Add(vid3);

        // Video 4
        Video vid4 = new Video("Understanding Encapsulation", "Dev Simplified", 380);
        vid4.AddComment(new Comment("Jessica", "Best explanation of private and public yet."));
        vid4.AddComment(new Comment("Kevin", "Thanks for making this video!"));
        vid4.AddComment(new Comment("Laura", "Crystal clear."));
        videos.Add(vid4);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}