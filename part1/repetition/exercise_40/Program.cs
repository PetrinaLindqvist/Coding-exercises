using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int count = 0;
      while (true)
    {
      Console.WriteLine("Give a number:"); 
      int number = Convert.ToInt32(Console.ReadLine());
      
      if (number == 0)
      {
        break;      
      }
      else 
      {
        sum = sum + number;
        count++;
      }
    }
    Console.WriteLine("Total sum of numbers: " + sum);
    Console.WriteLine("Total amount of numbers: " + count);
    }
    }
  }

