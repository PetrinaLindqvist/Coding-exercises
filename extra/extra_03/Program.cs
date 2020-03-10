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
      while (true)
      {
        count = Convert.ToInt32(Console.ReadLine());
        times++;
      
      if (times == input)
      {
        break;
      }

      sum = sum + count;
      }
      double average = (double)sum / times;
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + (count * count));
      Console.WriteLine("Their average: " + (count + count)/count);
    
    
    
    
    }
  }
}
