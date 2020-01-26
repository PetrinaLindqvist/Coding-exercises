using System;

namespace exercise_35
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
      
      if (input == "42")
      {
      break;
      }
    
      }
    }
  }
}
