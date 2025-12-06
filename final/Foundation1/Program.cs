using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _playlist = new List<Video>();

        //https://youtu.be/x9FAJjt7yTg
        Video DrawCircle = new Video("first you draw a circle", "Super", 43);
        DrawCircle.AddComment("TJ-Henry-Yoshi", "I'm still very amused by how the best looking one was written in the first try within the word 'HOW'");
        DrawCircle.AddComment("josephmeluso2377", "OCTAGON");
        DrawCircle.AddComment("HonorJanas", "When do we dot the eyes?");
        DrawCircle.AddComment("-ArtisticDemon-", "First you SUFFER");
        DrawCircle.AddComment("dbpt210", "drawn't");
        _playlist.Add(DrawCircle);

        // https://youtu.be/YUtWkvGDtTk
        Video ClockTown = new Video("Majora's Mask - Clock Town", "Orchestral Fantasy", 182);
        ClockTown.AddComment("amazinghoffman", "You'd make an excellent medieval monk.");
        ClockTown.AddComment("TerraEsperZ", "I'm so happy you covered all three days as the ominousness of Day 3 is one of my favourite piece of Zelda music!");
        ClockTown.AddComment("gamestar6479", "That one dislike has got to be from Majora");
        _playlist.Add(ClockTown);

        // https://youtu.be/2OebZ5HwdPs
        Video Polyanna = new Video("Mother: Pollyanna Jazz/Funk Cover (feat. FamilyJules, Adrisaurus & Sab Irene)", "insaneintherainmusic", 321);
        Polyanna.AddComment("TheBlueCario", "Me: *Turns on subtitles at 2:55\n Subtitles: [sick sax solo]\n Me: Well, they aren't lying.");
        Polyanna.AddComment("gravityhamster8805", "Cowbell/10 for Carlos' supra groovy dance moves!");
        Polyanna.AddComment("NathanielBandy", "That was incredible, really loved the arrangements in this one!");
        _playlist.Add(Polyanna);

        foreach (Video vid in _playlist)
        {
            vid.DisplayVideo();
            Console.WriteLine();
        }
    }
}