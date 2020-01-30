using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int userInput1 = Convert.ToInt32(Console.ReadLine());
            
      Console.WriteLine("Where from?");
      int userInput2 = Convert.ToInt32(Console.ReadLine());
     
      int count = userInput2;

      while (count <= userInput1)
     {
        Console.WriteLine(count);
        count++;
     }
    
    }
  }
}
