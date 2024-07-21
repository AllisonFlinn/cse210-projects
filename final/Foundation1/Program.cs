using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Making Soap with Only 3 Ingredients", "Travis Garcia", 480);

        Comment video1Comment1 = new Comment("Katie", "Thank you for your great recipe. I made 34 pieces of soap. I am very satisfied with soap.");
        Comment video1Comment2 = new Comment("Josh", "The video was so helpful and really explained step by step how to do it. I felt very confident making soap for the first time and it all turned out perfectly. Thank you! .");
        Comment video1Comment3 = new Comment("Maria", "Thanks for sharing your knowledge.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("9 ADHD Productivity Hacks", "Hailey Palomino", 975);

        Comment video2Comment1 = new Comment("Diego", "where were you from last 3 years when i was looking for the realistic content like yours !");
        Comment video2Comment2 = new Comment("Valeria", "Shared this with my ADHD husband - he thinks some of these tips will really help him get organized.");
        Comment video2Comment3 = new Comment("Camilla", "This video is great! Would love to see more suggestions for non-money related small treats.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Why You Procrastinate-and How to Stop it for Good", "Elyssa Smith", 650);

        Comment video3Comment1 = new Comment("Gabby", "I love how the speaker breaks down this information to make it accessible and practical to apply to my daily life!");
        Comment video3Comment2 = new Comment("Rene", "What an informative talk and method to conquer the monster of procrastination. I can relate..");
        Comment video3Comment3 = new Comment("Fred", "This talk has been so impactful and makes so much sense. It is really making do a deep dive on this internally.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}