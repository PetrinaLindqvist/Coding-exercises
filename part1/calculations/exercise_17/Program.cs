using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string numBer1 = Console.ReadLine();
      int first = Convert.ToInt32(numBer1);


      Console.WriteLine("Give the second number!");
      string numBer2 = Console.ReadLine();
      int second = Convert.ToInt32(numBer2);
      Console.WriteLine("The sum is " + (first + second));
   
    }
  }
}
