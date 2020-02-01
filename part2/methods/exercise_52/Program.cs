using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(5);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
    {
      
      while (number > 0)
      {
        Console.WriteLine(number);
        number--;
      }
    }
  
  }
 }
