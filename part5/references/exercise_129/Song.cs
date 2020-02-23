using System;

namespace exercise_129
{

  public class Song
  {

    private string artist;
    private string name;
    private int durationInSeconds;

    public Song(string artist, string name, int durationInSeconds)
    {
      this.artist = artist;
      this.name = name;
      this.durationInSeconds = durationInSeconds;
    }

    public override string ToString()
    {
      return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
    }

    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
      // if the variables are located in the same position, they are equal
      if (this == compared)
      {
        return true;
      }

      // if the compared object is null, or
      // if the type of the compared object is not SimpleDate, the objects are not equal
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }

      // convert the Object type compared object
      // into an SimpleDate type object called comparedSimpleDate
      Song comparedSong = (Song)compared;

      // if the values of the object variables are the same, the objects are equal
      if (this.artist == comparedSong.artist &&
          this.name == comparedSong.name &&
          this.durationInSeconds == comparedSong.durationInSeconds)
      {
        return true;
      }

      // otherwise the objects are not equal
      return false;
  
    // END SOLUTION
    }
  }

}