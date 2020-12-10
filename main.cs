using System;

class MainClass {
  public static void Main (string[] args) {
    Artist a1 = new Artist("Taylor", "Swift");
    a1.Display();
    Song s1 = new Song(1, "Girl At Home");
    s1.AddArtistInfo(a1);
    Song s2 = new Song(2, "The Last Time");
    s2.AddArtistInfo(a1);
    Song s3 = new Song(3, "The Moment I Knew");
    s3.AddArtistInfo(a1);
    s1.Display();
    s2.Display();
    s3.Display();
    Album ab1 = new Album("Red");
    ab1.AddSong(s1);
    ab1.AddSong(s2);
    ab1.AddSong(s3);
    ab1.DisplaySongs();
    ab1.RemoveSong(2);
    ab1.DisplaySongs();
  }
}