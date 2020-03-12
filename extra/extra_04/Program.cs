using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]: ");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number >= 0 && number < 50)
      {
        Console.WriteLine("Fail");
      }
      else if (number >= 50 && number < 60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (number >= 60 && number < 70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (number >= 70 && number < 80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (number >= 80 && number < 90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (number >= 90 && number < 101)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (number >= 100)
      {
        Console.WriteLine("Outstanding!");
      }
      else 
      {
        Console.WriteLine("Impossible");
      }
    }
  }
}
