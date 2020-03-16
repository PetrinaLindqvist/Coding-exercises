using System;
using System.IO;
namespace extra_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      string text = File.ReadAllText("text.txt");
      
      Console.WriteLine(text);
    }
   
    
  }
}
