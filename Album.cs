using System;
using System.Collections.Generic;
class Album
{
  public string Title{get; set;}
  public List<Song> ListOfSongs = new List<Song>(); 
  public Album(string title)
  {
    Title = title;
  }
  public void AddSong(Song s)
  {
    ListOfSongs.Add(s);
    Console.WriteLine("Song: " + s.Title + " Has Been Added To Album: " + Title);
  }
  public void RemoveSong(int ID)
  {
    Song temp = ListOfSongs.Find((r) => {return r.ID == ID;});
    ListOfSongs.Remove(temp);
    Console.WriteLine("Song: " + temp.Title + " Has Been Removed From Album: " + Title);
  }
  public void DisplaySongs()
  {
    Console.WriteLine("Songs In Album: " + Title);
    foreach (Song s in ListOfSongs)
    {
      s.Display();
    }
  }
}