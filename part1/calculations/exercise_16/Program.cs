using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string userInput = Console.ReadLine();
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine(intValue * 24 * 60 * 60);
    }
  }
}
