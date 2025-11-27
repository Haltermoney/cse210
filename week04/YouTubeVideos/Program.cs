/* keep track of youtube videos and comments left on them. Store information about the video and the comments.

*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Video chocolateRain = new Video("Chocolate Rain", 278, "TayZonday");
        Video numaNuma = new Video("Numa Numa", 100, "Gary Brolsma");
        Video charlie = new Video("Charlie Bit My Finger", 56, "jasminmakup");
        Video charlieTheUnicorn = new Video("Charlie the Unicorn", 226, "FilmCow");

        chocolateRain.AddComment("Hypno toad", "This song is fire!");
        chocolateRain.AddComment("John Doe", "So much talent");
        chocolateRain.AddComment("Happy_Camper", "Chocolate Rain!");

        numaNuma.AddComment("I_Was_First", "FIRST!!!");
        numaNuma.AddComment("abrakadabra", "This is the beast thing I have ever seen!");
        numaNuma.AddComment("T-rex", "Raar");
        numaNuma.AddComment("Celine Dion", "SO inspiring");

        charlie.AddComment("Charlie's Mom", "I love my kids");
        charlie.AddComment("Upstanding Citizen", "OW, Charlie. HAHAHA!");
        charlie.AddComment("PAPA", "So funny");

        charlieTheUnicorn.AddComment("90's Child", "This is so funny");
        charlieTheUnicorn.AddComment("Gen X", "What did I just watch?");
        charlieTheUnicorn.AddComment("My Dad", "???");

        Console.Clear();

        chocolateRain.GetVideo();
        chocolateRain.GetComments();
        numaNuma.GetVideo();
        numaNuma.GetComments();
        charlie.GetVideo();
        charlie.GetComments();
        charlieTheUnicorn.GetVideo();
        charlieTheUnicorn.GetComments();
    }
}