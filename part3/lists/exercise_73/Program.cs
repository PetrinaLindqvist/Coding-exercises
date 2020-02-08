using System;
using System.Collections.Generic;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      int sum = 0;

      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
        
      }
      
      for (int i=0; i < list.Count; i++)
      sum += list[i];
    {
     Console.WriteLine("Sum: " + sum);
    } 
      
    }
  }
}
