using System;

namespace extra_01
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      
      Console.WriteLine("What do you want to print?");
      string input = Console.ReadLine();
      Console.WriteLine("How many times do you want to print?");
      int times = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      while (true)
      { 
        Console.WriteLine(input);
        count++;
      
        if (count == times)
        {
          break;
        }
      }
    
    }
  }
}
