using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give integers, 'end' quits:");
      
      while (true)
      {
      int nbr = Convert.ToInt32(Console.ReadLine());
      string word = Console.ReadLine();
     
        if (word == "end")
        {
          break; 
        }
        Console.WriteLine("Sum: " + (nbr + nbr));
      }
    
    }
  }
}
