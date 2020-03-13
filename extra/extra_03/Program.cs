using System;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("How many numbers? ");
      int input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + input + " numbers: ");
      int times = 0;
      int count = 0;
      int sum = 0;
      int total = 1;
      double average = 0;
      while (true)
      {
        count = Convert.ToInt32(Console.ReadLine());
        times++;
        sum = sum + count;
        total = total * count;
        average = (double)sum / input;
      if (times == input)
      {
        break;
      }

      
      }
    Console.WriteLine("Their sum: " + sum);
    Console.WriteLine("Their total: " + total);
    Console.WriteLine("Their average: " + average);
    
    
    
    
    }
  }
}
