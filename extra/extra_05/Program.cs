using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<string> list = new List<string>();
      for (int i = 1; i < 6; i ++)
      {
        Console.WriteLine(i);
      }
      
      Console.WriteLine("Give words, 'end' quits:");
      
        while (true)
        {
        string word = Console.ReadLine();
        if (word == "end")
        {
          break;
        }
        list.Add(word);
        }
        list.ForEach(Console.WriteLine);


       
    }
  } 
}
