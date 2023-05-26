using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Foundation Program 1\n");
        Console.Write("--------------------\n");
        Console.WriteLine("(Abstraction: The process of turning complex ideas into simple ones.)\n");


        Comment comment1 = new Comment();
        comment1._name = "Bubba Chuck";
        comment1._commentText = "This video is a must see!";
        Comment comment2 = new Comment();
        comment2._name = "Bobby Brown";
        comment2._commentText = "Pure Gold!";
        Comment comment3 = new Comment();
        comment3._name = "Ms. Madonna";
        comment3._commentText = "Who knew Spiders were so cool!";
        Comment comment4 = new Comment();
        comment4._name = "Arial M.";
        comment4._commentText = "I wish I could swing through the air like this guy!";
        Comment comment5 = new Comment();
        comment5._name = "Robin";
        comment5._commentText = "Love this guy.  He makes it look so easy.";
        Comment comment6 = new Comment();
        comment6._name = "Mr. Joker";
        comment6._commentText = "You know the batman isn't that big of a deal right?";
        Comment comment7 = new Comment();
        comment7._name = "Ms. Catwoman";
        comment7._commentText = "Very handsome! I could watch this over and over.";
        Comment comment8 = new Comment();
        comment8._name = "Lois L.";
        comment8._commentText = "It is a mazing the difference I see just from him removing his glasses.";
        Comment comment9 = new Comment();
        comment9._name = "Lex";
        comment9._commentText = "This guy is always a problem for me.  I need to stop watching these videos.";
        Comment comment10 = new Comment();
        comment10._name = "Perry White";
        comment10._commentText = "Always a good story when Superman is around.";
        Comment comment11 = new Comment();
        comment11._name = "K. Kryptonite";
        comment11._commentText = "I just don't get this guy.  Not much of a superhero in my book.";
        Comment comment12 = new Comment();
        comment12._name = "Mayor Small";
        comment12._commentText = "Makes me miss Smallville.";

        Video video1 = new Video();
        video1._title = "Spiderman";
        video1._author = "Peter Parker";
        video1._videoLength = 45;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);
        

        Video video2 = new Video();
        video2._title = "Batman";
        video2._author = "Bruce Wayne";
        video2._videoLength = 35;
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        

        Video video3 = new Video();
        video3._title = "Superman";
        video3._author = "Clark Kent";
        video3._videoLength = 107;
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);

        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
        video3.DisplayVideoDetails();







    }
}