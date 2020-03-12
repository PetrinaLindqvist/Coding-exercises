using System;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give a sentence:");
      while(true)
      {
        string something = Console.ReadLine();
        if (something == "")
        {
          break;
        }
        string[] parts = something.Split(" ");
        foreach (string line in parts)
        {
          Console.WriteLine(line);
        }
      
      }
    }
  }
}
