using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Teacher ada = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
      Teacher esko = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
      Console.WriteLine(ada);
      Console.WriteLine(esko);
 
    }
  }
}
