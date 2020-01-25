using System;

namespace exercise_21
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
    
      double average = (first + second) / 2.0;
      Console.WriteLine("The average is " + average);

  
  
    }
  }
}
