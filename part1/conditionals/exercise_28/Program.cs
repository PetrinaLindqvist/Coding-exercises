using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      string userNbr = Console.ReadLine();
      int nbr = Convert.ToInt32(userNbr);
      if (nbr >= 18 )
      {
        Console.WriteLine("You're an adult!");
      }
      else
      {
        Console.WriteLine("You're under age!");
      }
    }
  }
}
