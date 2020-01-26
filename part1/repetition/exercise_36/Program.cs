using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
    {
      Console.WriteLine("Give a number:");
      String input = Console.ReadLine();
      int intValue = Convert.ToInt32(input);
      
      if (intValue == 0)
      {
      break;      
      }
      else if (intValue > 0)
      {
        Console.WriteLine(intValue * intValue);
      }
      else
      {
        Console.WriteLine("That is negative");

      }
    }
    }
  }
}
