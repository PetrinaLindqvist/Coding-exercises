using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string userNbr = Console.ReadLine();
      int nbr = Convert.ToInt32(userNbr);
      if (nbr < 1900)
      {
        Console.WriteLine("You're old");
      }
      }
   
    }
  }
}
