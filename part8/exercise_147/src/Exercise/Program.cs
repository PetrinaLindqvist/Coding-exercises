using System;

namespace Exercise 
{
  public class Program 
  {
    public static void Main(string[] args) 
    {
      StorageFacility facility = new StorageFacility();
      facility.Add("a14", "ice skates");
      facility.Add("a14", "ice hockey stick");
      facility.Add("a14", "ice skates");

      facility.Add("f156", "rollerblades");
      facility.Add("f156", "rollerblades");

      facility.Add("g63", "six");
      facility.Add("g63", "pi");

      foreach (string unit in facility.StorageUnits()) 
      {
        Console.WriteLine(unit);
      }

      foreach (string item in facility.Contents("a14")) 
      {
        Console.WriteLine(item);
      }

      foreach (string item in facility.Contents ("f156")) {
        Console.WriteLine (item);
      }
      facility.Remove("f156", "rollerblades");

      foreach (string item in facility.Contents("f156")) 
      {
        Console.WriteLine(item);
      }

      facility.Remove("f156", "rollerblades");

      foreach (string unit in facility.StorageUnits()) 
      {
        Console.WriteLine(unit);
      }
    }
  }
}