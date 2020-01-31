using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      // Write your code here:
      Console.WriteLine("Give numbers:");
      while (true) 
      {
        int number = Convert.ToInt32(Console.ReadLine());
        sum = sum + number;
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == -1) break;
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
    }
  }
}
