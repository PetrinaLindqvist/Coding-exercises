using System;
namespace Exercise
{
  public class LicensePlate
  {
    public string liNumber { get; }
    private string country;

    public LicensePlate(string country, string liNumber)
    {
      this.liNumber = liNumber;
      this.country = country;
    }


    public override string ToString()
    {
      return country + " " + liNumber;
    }

    public override bool Equals(object compared)
    {
      // if the variables are located in the same position, they are equal
      if (this == compared)
      {
        return true;
      }

      // if the compared object is null or not of type, the objects are not equal
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      else
      {
        // convert the object to a Plate object
        LicensePlate comparedPlate = (LicensePlate)compared;

        // if the values of the object variables are equal, the objects are, too
        return this.liNumber == comparedPlate.liNumber && this.country == comparedPlate.country;
      }
    }
    public override int GetHashCode()
    {
      return HashCode.Combine(this.liNumber, this.country);
    }
  }
}