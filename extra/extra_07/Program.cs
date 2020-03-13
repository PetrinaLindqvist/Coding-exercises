using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give integers, 'end' quits:");
      int sum = 0;
      
      while (true)
      {
      
        string word = Console.ReadLine();
      
        if (word == "end")
        {
          break; 
        }
        sum += Convert.ToInt32(word);
      }
    
       Console.WriteLine("Sum: " + sum);
    
    }

     
  }
}
