using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userNbr = Console.ReadLine();
      int nbr = Convert.ToInt32(userNbr);
      if (nbr > 0 )
      {
        Console.WriteLine("It is positive");
      }
      else
      {
        Console.WriteLine("It is not positive");
      }
    }
  }
}
