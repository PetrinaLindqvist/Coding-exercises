using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number!");
      string userNbr = Console.ReadLine();
      double doubleValue = Convert.ToDouble(userNbr);
      Console.WriteLine("You gave " + doubleValue);
  }
}
}