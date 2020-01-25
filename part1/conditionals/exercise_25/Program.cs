using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userNbr = Console.ReadLine();
      int nbr = Convert.ToInt32(userNbr);
      if (nbr == 1984)
      {
        Console.WriteLine("Orwell");
      }
   
    }
  }
}
