using System;
class Song
{
  public int ID{get; set;}
  public string Title{get; set;}
  public Artist ArtistInfo{get; set;} 
  public Song()
  {
    ID = 0;
    Title = "Unknown";
  }
  public Song(int id, string title)
  {
    ID = id;
    Title = title;
  }
  public void AddArtistInfo(Artist a)
  {
    ArtistInfo = a;
    Console.WriteLine("Artist " + a.FirstName + " " + a.LastName + " To The Song Titled" + Title);
  }
  public void Display()
  {
    Console.WriteLine("Song Info: " + ID + " " + Title + " " + ArtistInfo.FirstName + " " + ArtistInfo.LastName);
  }
}