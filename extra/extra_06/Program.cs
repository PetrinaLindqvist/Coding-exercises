using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int nbr1 = Convert.ToInt32(Console.ReadLine());
      int nbr2 = Convert.ToInt32(Console.ReadLine());
      int sum = nbr1 + nbr2;
      double squareRoot = Math.Sqrt(sum);
      
      if (sum < 0)
      {
        Console.WriteLine("0");
      }
      Console.WriteLine(squareRoot);
      
    
    }
  }
}
