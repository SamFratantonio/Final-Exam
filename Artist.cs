using System;
class Artist 
{
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public string Email {get; set;}
  public Artist(string fname, string lname)
  {
    FirstName = fname;
    LastName = lname;
    Email = "Unknown";
  }
  public void Display()
  {
    Console.WriteLine("Artist: " + FirstName + " " + LastName);
  }
}