using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int nbr = Convert.ToInt32(Console.ReadLine());

      if (nbr <0)
      {
          Console.WriteLine(nbr * -1);
      } 
      else
      {
          Console.WriteLine(nbr);
      }



    }
  }
}
