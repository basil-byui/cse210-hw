using System;

class Program
{
    static void Main(string[] args)
    {
        Video videoA = new Video("static methods and Classes", "Giraffe Academy", 1800);
        Video videoB = new Video("The role of the Holy Ghost in Conversion", "Elder Bednar", 900);
        Video videoC = new Video("Object Oriented Programing", "Peter Frances", 560);

        // Comments on the videos, adding three comments per video
        videoA.AddComment(new Comment("Sifiso Khuzwayo", "Very helpful, thank you!"));
        videoA.AddComment(new Comment("Xolani Mthabela", "Amazing explanation, Claar and concise."));
        videoA.AddComment(new Comment("Nonhlanhla Nsindane", "Really good video. Concise, short, explained in plain words with a good example."));

        videoB.AddComment(new Comment("Gcaba Mboneni", "We are the work of God's work here on earth. I love this concept."));
        videoB.AddComment(new Comment ("Nstangase Bhekithemba", "Thank you so much, that is very powerful lesson."));
        videoB.AddComment(new Comment ("Tsepo Xulu", "For God so loved the world that he gave His son that all men may be saved."));

        videoC.AddComment(new Comment( "Mxhakaza Ayanda", "I've looked at several videos and blogs and they all make it so complicated. Thanks!"));
        videoC.AddComment(new Comment ("Hlengiwe Khuzwayo", "I now get this 100%."));
        videoC.AddComment(new Comment ("Xhegu Ngxabano", "Explained in well comprehensive way.. Keep it up"));


        // List stored with videos
        List<Video> videos = new List<Video> {videoA, videoB, videoC};
        foreach(var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Auther}");
            Console.WriteLine($"Length: {video.Length} sec");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");


            // displaying comments
            Console.WriteLine("Comments:");
            foreach(var comment in video.GetComments())
            {
                Console.WriteLine("" + comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
            

        }
    
    }

}