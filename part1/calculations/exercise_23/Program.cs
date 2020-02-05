using System;

namespace exercise_23
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
    
      Console.WriteLine(first + " + " + second + " = " + (first+second));
      Console.WriteLine(first + " - " + second + " = " + (first-second));
      Console.WriteLine(first + " * " + second + " = " + (first*second));
      Console.WriteLine(first + " / " + second + " = " + ((double)first/second));
   
   
   
   
    }
  }
}
