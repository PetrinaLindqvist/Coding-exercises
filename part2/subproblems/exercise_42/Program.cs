using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
    int nbr1 = Convert.ToInt32(Console.ReadLine());
    int nbr2 = Convert.ToInt32(Console.ReadLine());

    int sum = (nbr1 + nbr2);
    double squareRoot = Math.Sqrt(sum);
    Console.WriteLine(squareRoot);



    }
  }
}
