using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
// --- Video 1 ---
Video video1 = new Video("How Coca-Cola Is Made — Factory Tour", "Inside Manufacturing", 743);
video1.AddComment(new Comment("Sarah Johnson", "I had no idea how complex the bottling process was. Incredibly informative!"));
video1.AddComment(new Comment("Mike Torres", "That moment at 4:30 where they show the syrup mixing is mesmerizing."));
video1.AddComment(new Comment("Ava Patel", "Would love to see a behind-the-scenes on the secret formula itself."));
video1.AddComment(new Comment("Derek Haines", "Subscribed instantly. Keep these factory tours coming!"));
videos.Add(video1);
// --- Video 2 ---
Video video2 = new Video("Pepsi vs Coke — Blind Taste Test (2024)", "FoodLab Channel", 482);
video2.AddComment(new Comment("Jessica Wu", "I picked Pepsi in the blind test too, but I still buy Coke. Make it make sense."));
video2.AddComment(new Comment("Liam Okafor", "The sip test always favors Pepsi but Coke wins with the full can. Classic result."));
video2.AddComment(new Comment("Natasha Reeves", "This was so well done — neutral, fair, and actually interesting."));
videos.Add(video2);
// --- Video 3 ---
Video video3 = new Video("Nike Running Shoes 2024 — Full Review", "GearHead Reviews", 1021);
video3.AddComment(new Comment("Carlos Mendes", "Perfect timing — I was just about to order a pair. This helped me decide."));
video3.AddComment(new Comment("Hannah Brooks", "I wish you had compared the heel drop to the Adidas equivalent."));
video3.AddComment(new Comment("James Yoo", "17 minutes of pure substance, no filler. Rare these days."));
video3.AddComment(new Comment("Sophie Grant", "Bought these based on your last review and they lasted 2 years. Trusting you again."));
videos.Add(video3);
// --- Video 4 ---
Video video4 = new Video("Unboxing the iPhone 16 Pro — First Look", "TechPulse", 614);
video4.AddComment(new Comment("Omar Shaikh", "The camera button is the one feature I actually care about. Glad they kept it."));
video4.AddComment(new Comment("Emily Chen", "You got yours a full week before me. Jealous doesn't begin to cover it."));
video4.AddComment(new Comment("Ryder Walsh", "Still on the 14 Pro and not feeling the urge to upgrade yet."));
videos.Add(video4);
// --- Display all videos ---
foreach (Video video in videos)
{
    Console.WriteLine($"Title:    {video.GetTitle()}");
    Console.WriteLine($"Author:   {video.GetAuthor()}");
    Console.WriteLine($"Length:   {video.GetLengthInSeconds()} seconds");
    Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
    foreach (Comment comment in video.GetComments())
    {
        Console.WriteLine($"  - {comment.GetAuthor()}: {comment.GetText()}");
    }
    Console.WriteLine();
}
    }
}